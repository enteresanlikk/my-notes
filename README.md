# docker-examples

## structure
- docker deamon
- docker rest api
- docker cli

## commands
- docker version
- docker info
- docker run hello-world

## containers
- docker container
- docker container list -a
- docker ps -a
- docker container create
- docker container start
- docker container stop
- docker container rm
- docker container run
- docker container -d -p 80:80 nginx -> -d detach, -p port mapping
- docker container exec -it 1c9f sh/bash -> -it interactive terminal
- docker container prune
- docker container run -it -v my-vol:/app alpine sh
- docker container run -it -v my-vol:/app:ro alpine sh -> read only

- -p / --publish -> port mapping (host:container)

- docker attach 1c9f -> attach to container

## images
- docker image ls
- docker image pull
- docker image prune -a

## volumes
- docker volume ls
- docker volume create my-vol
- docker volume inspect my-vol
- docker volume prune

## networks
- bridge -> default
- host -> host network
- none -> no network

- macvlan -> mac address
- overlay -> swarm

- docker network ls
- docker network create my-net
- docker network inspect my-net
- docker network connect my-net 1c9f
- docker network disconnect my-net 1c9f

- docker network create --driver=bridge --subnet=10.10.0.0/16 --ip-range=10.10.10.0/24 --gateway=10.10.10.10 NETWORK_NAME
- docker network connect NETWORK_NAME CONTAINER_NAME
- docker network disconnect NETWORK_NAME CONTAINER_NAME

## logs
- STDIN
- STDOUT
- STDERR

- docker logs -t --details CONTAINER_NAME|ID
- docker logs --until DATE CONTAINER_NAME|ID
- docker logs --since DATE CONTAINER_NAME|ID
- docker logs --tail COUNT CONTAINER_NAME|ID
- docker logs -f CONTAINER_NAME|ID

## top
- docker top CONTAINER_NAME|ID

## stats
- docker stats
- docker stats --no-stream
- docker stats CONTAINER_NAME|ID

## cpu and memory limits
- docker container run -d --memory=50m nginx
- docker container run -d --memory=50m --memory-swap=100m nginx
- docker container run -d --cpus="1.5" nginx
- docker container run -d --cpus="1.5" --cpuset-cpus="0,1" nginx

## environment variables
- Get-ChildItem Env: -> windows
- $Env:windir -> windows
- $Env:test="deneme" -> windows

- docker container run -it --env VAR=VALUE -e VAR2=VALUE2 nginx sh
- docker container run -it --env-file .env nginx sh

## save and load images
- docker save -o IMAGE_NAME my-image.tar
- docker load -i my-image.tar