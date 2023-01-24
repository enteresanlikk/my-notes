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
- kubectl logs first-pod
    - kubectl logs -f first-pod - follow
- kubectl exec first-pod -- ls
- kubectl exec -it first-pod -- sh
- kubectl apply -f pod-file.yml

## yaml
### content structure
- apiVersion: v1|apps/v1|...
- kind: Pod|Deployment|Service|Ingress|...
- metadata
    - unique datas
- spec