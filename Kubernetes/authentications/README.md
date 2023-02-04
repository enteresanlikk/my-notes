# authentications
- X509 Client Certs
- Static Token File
- OpenID Connect Tokens
- Webhook Token Authentication
- Authenticating Proxy

## create key and csr
1. openssl genrsa -out bilaldemir.key 2048
2. openssl req -new -key bilaldemir.key -out bilaldemir.csr -subj "/CN=bilal@bilal/O=DevTeam"

## create CertificateSigningRequest
```
$ cat <<EOF | kubectl apply -f -
apiVersion: certificates.k8s.io/v1
kind: CertificateSigningRequest
metadata:
  name: bilaldemir
spec:
  groups:
  - system:authenticated
  request: $(cat bilaldemir.csr | base64 | tr -d "\n")
  signerName: kubernetes.io/kube-apiserver-client
  usages:
  - client auth
EOF
```

## approve csr and get crt
1. kubectl get csr
2. kubectl certificate approve bilaldemir
3. kubectl get csr bilaldemir -o jsonpath='{.status.certificate}' | base64 -d >> bilaldemir.crt

## kubectl config
1. kubectl config set-credentials bilal@bilal --client-certificate=bilaldemir.crt --client-key=bilaldemir.key
2. kubectl config set-context bilaldemir-context --cluster=minikube --user=bilal@bilal
3. kubectl config use-context bilaldemir-context