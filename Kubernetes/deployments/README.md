# deployments
- replicas

## commands
- kubectl create deployment deployment-nginx --image=nginx --replicas=3
- kubectl get deployment
- kubectl delete deployment deployment-nginx
- kubectl set image deployment/deployment-nginx nginx=httpd
- kubectl scale deployment deployment-nginx --replicas=10
- kubectl apply -f deployment-file.yml
- kubectl rollout undo deployment deployment-nginx
- kubectl delete rs rs-nginx