# Kubernetes (k8s) [kubernetes.io](https://kubernetes.io)
- [Udemy Course](https://www.udemy.com/course/kubernetes-temelleri/)
- container orchestration system
- open source
- [cncf.io](https://cncf.io) project
- semantic versioning
- 12 month release cycle

## structure
- master node
  - kube-apiserver
  - etcd
  - kube-scheduler
  - kube-controller-manager
- worker node
  - container runtime (docker, containerd, cri-o)
  - kubelet
  - kube-proxy

## management systems
- kubectl - command line tool
- minikube - local development
- docker desktop - local development
- production
  - k0s
  - kubespray
  - kubeadm
  - rke
- cloud
  - amazon eks
  - google gke
  - azure aks

## kubectl
- **If you're lost, use --help!**
- kubectl <verb> <resource> <name>
- kubectl get pods
  - kubectl get pods -n kube-system
  - kubectl get pods -A|--all-namespaces
- kubctl config
  - **/.kube/config** - configuration file
  - kubectl config get-contexts
  - kubectl config use-context <context>
  - kubectl config current-context
- output
  - kubectl get pods -A -o wide
  - kubectl get pods -A -o yaml
  - kubectl get pods -A -o json
  - kubectl get pods -A -o jsonpath='{.items[*].metadata.name}'
- kubectl explain <resource>
  - kubectl explain pod
- kubectl describe <resource> <name>
- kubectl edit <resource> <name>

## general
- use yaml file for configuration