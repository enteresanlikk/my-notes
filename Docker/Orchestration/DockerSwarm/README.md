## structure
- manager
    - number must be odd.
    - It is recommended to have a maximum of 7 managers.
    - It is recommended to have a minimum of 3 managers.
- worker

## commands
- docker swarm init --advertise-addr 192.168.0.10
- docker swarm join-token manager
- docker swarm join-token worker
- docker node ls
- docker service create --name s_nginx --replicas=5 -p 80:80 nginx
- docker service ls
- docker service ps s_nginx

## overlay network
- docker network create --driver overlay my-net

## service update
- docker service update --detach --update-delay 5s --update-parallelism 2 --update-failure-action rollback --update-monitor 10s --image nginx:1.13.0 s_nginx

## secrets
- docker secret ls
- docker secret create my_secret my_secret.txt
- docker secret rm my_secret
- docker service update --secret-rm my_secret --secret-add new_my_secret s_nginx

## stack
- docker stack ls
- docker stack deploy -c docker-compose.yml my_stack
- docker stack services my_stack
- docker stack ps my_stack
- docker stack rm my_stack