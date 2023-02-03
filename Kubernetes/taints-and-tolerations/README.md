# taints and tolerations

## operators
- Equal
- Exists

## effects
- NoSchedule
- PreferNoSchedule
- NoExecute

## commands
- kubectl taint node node1 key1=value1:NoSchedule
- kubectl taint node key1-