# image secrets

# imagePullPolicy
- Always
- IfNotPresent
- Never

# create secrets
```bash
kubectl create secret docker-registry "secret_name" --docker-server="registry_url" --docker-username="username" --docker-password="password"
```