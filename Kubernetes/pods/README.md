# pods
- the smallest deployable unit of objects in k8s
- a pod is a group of one or more containers
- a pod has a single IP address
- settings with yaml files or kubectl commands

## commands
- kubectl get pods
- kubectl run first-pod --image=nginx --restart=Never
- kubectl describe pods first-pod
- kubectl delete pods first-pod - **Caution!**
- kubectl delete -f pod-file.yml
- kubectl logs first-pod
    - kubectl logs -f first-pod - follow
- kubectl exec first-pod -- ls
- kubectl exec -it first-pod -- sh
- kubectl apply -f pod-file.yml
- kubectl get pods -l "app=firstapp,tier=backend" --show-labels
    - "app in (firstapp,secondapp)"
    - "tier notin (frontend,backend)"
    - "app=firstapp,tier=backend"
    - "app, tier"
- kubectl label pods first-pod app=firstapp
- kubectl annotate pods first-pod owner=Bilal
- kubectl create namespace dev
- kubectl get namespaces
- kubectl get pods --namespace dev
- kubectl config set-context --current --namespace=dev
- kubectl delete namespace dev

## yaml
### content structure
- apiVersion: v1|apps/v1|...
- kind: Pod|Deployment|Service|Ingress|...
- metadata
    - unique datas
- spec

## lifecycle
- pending
- creating
- imagepullbackoff
- running
- succeeded
- failed
- crashloopbackoff