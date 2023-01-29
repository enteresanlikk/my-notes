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

## rollout and rollback
- kubectl apply -f deployment-file.yml --record
- kubectl rollout history deployment deployment-nginx
- kubectl rollout history deployment deployment-nginx --revision=2
- kubectl rollout undo deployment deployment-nginx --to-revision=2
- kubectl rollout status deployment deployment-nginx -w
- kubeclt rollout pause deployment deployment-nginx
- kubeclt rollout resume deployment deployment-nginx
- strategy
    - type: RollingUpdate (default)
        - desc: before updating the deployment, it will create new pods and then delete old pods
        - maxSurge: 1 (number or percentage) (default 25%)
        - maxUnavailable: 1 (number or percentage) (default 25%)
    - type: Recreate
        - desc: before updating the deployment, it will delete all the pods and then create new pods