# Kubernetes (k8s) [kubernetes.io](https://kubernetes.io) 
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