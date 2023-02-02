# services

## commands
- kubectl get services
- kubectl expose deployment <name> --port=<port> --target-port=<port> --type=<type> --name=<name>

## types
- ClusterIP
- NodePort
- LoadBalancer

## info
- dns name: <name>.<namespace>.svc.cluster.<domain>