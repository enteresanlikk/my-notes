# secrets
- secret
- configmap

## commands
- kubectl get secrets
- kubectl describe secrets
- create secret
    - kubectl create secret generic mysecret --from-literal=key1=value1 --from-literal=key2=value2
    - kubectl create secret generic mysecret2 --from-file=db_server=server.txt --from-file=db_user=user.txt
    - kubectl create secret generic mysecret3 --from-file=config.json
- create configmap
    - kubectl create configmap myconfig --from-literal=key1=value1 --from-literal=key2=value2
    - kubectl create configmap myconfig2 --from-file=db_server=server.txt --from-file=db_user=user.txt
    - kubectl create configmap myconfig3 --from-file=config.json

## types
- Opaque
- kubernetes.io/service-account-token
- kubernetes.io/dockercfg
- kubernetes.io/dockerconfigjson
- kubernetes.io/basic-auth
- kubernetes.io/ssh-auth
- kubernetes.io/tls
- bootstrap.kubernetes.io/token