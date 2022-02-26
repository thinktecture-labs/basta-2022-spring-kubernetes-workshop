# BASTA! Spring 2022 Kubernetes Workshop

Link to the repository: [https://bit.ly/b2022repo](https://bit.ly/b2022repo)

## Playbook

1. 08:30 - 10:00: Introduction / creating and connecting to a Kubernetes cluster
2. 10:30 - 12:00: Containerizing and deploying a .NET Api to Kubernetes
3. 13:00 - 14:30: Working with Helm Charts / creating Ingress rules / embrace the Kubernetes platform
4. 15:00 - 16:30: Containerize and run .NET Apps as Job and/or CronJob

## Links

- [KIND](https://kind.sigs.k8s.io/docs/user/quick-start/)
- Burst Mode in Kubernetes with cloud engines -> https://virtual-kubelet.io/
- [Kubernetes Extension for VSCode](https://marketplace.visualstudio.com/items?itemName=ms-kubernetes-tools.vscode-kubernetes-tools)
- [Hey Load Generator](https://github.com/rakyll/hey)
- [KEDA - Kubernetes EventDriven Architectures](https://keda.sh/)
- [Kubectl Cheat-Sheet](https://github.com/dennyzhang/cheatsheet-kubernetes-A4)
- [NGINX Ingress Controller](https://kubernetes.github.io/ingress-nginx/)
- [Helm Package Manager](https://helm.sh)
- [kubectl Plugins with Krew](https://krew.sigs.k8s.io/plugins/)
- [DAPR (Distributed Application Runtime)](https://dapr.io/)
- [Service Mesh comparison](https://servicemesh.es/)
- [Service Mesh Interface Specification (SMI Spec)](https://smi-spec.io/)
- [cert-manager](https://cert-manager.io/)
- [Configure AKS Prometheus Scraping](https://docs.microsoft.com/en-us/azure/azure-monitor/containers/container-insights-prometheus-integration#applying-updated-configmap)
- [external-dns](https://github.com/kubernetes-sigs/external-dns)
- [Blog post on AKS and external-dns](https://www.thorsten-hans.com/external-dns-azure-kubernetes-service-azure-dns/)
- [Debugging Apps in Kubernetes with Bridge to Kubernetes](https://www.thorsten-hans.com/debugging-apps-in-kubernetes-with-bridge/)

## VSCode Extensions used during the workshop

- [Docker](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-docker)
- [Kubernetes](https://marketplace.visualstudio.com/items?itemName=ms-kubernetes-tools.vscode-kubernetes-tools)
- [Remote Containers](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers)
- [Yaml](https://marketplace.visualstudio.com/items?itemName=redhat.vscode-yaml)
- [Helm IntelliSense](https://marketplace.visualstudio.com/items?itemName=Tim-Koehler.helm-intellisense)

## Useful tools

- [cTop](https://github.com/bcicen/ctop)
- [Lens - The Kubernetes IDE](https://k8slens.dev/)

## Commands used during the workshop

```bash
# list namespaces
kubectl get namespace
# list nodes
kubectl get node

# list all Kubernetes Clusters you've access to
kubectl config get-contexts

# Get Credentials for an AKS cluster
az aks get-credentials -n <AKS_CLUSTER_NAME> -g <RESOURCE_GROUP_NAME>

# Switch to another Kubernetes cluster
kubectl config use-context <CONTEXT_NAME>

# Change default namespace
kubectl config set-context --current --namepsace <NEW_DEFAULT_NAMESPACE>

# get resources available in the current cluster
kubectl api-resources

# get pods
kubectl get pod
kubectl get po

# get deployments
kubectl get deployment
kubectl get deploy

# get services
kubectl get service
kubectl get svc

# get endpoints
kubectl get endpoint
kubectl get ep

# create a new namespace
kubectl create namespace api

# create YAML definition for a new namespace and store it to a file
kubectl create namespace api2 --dry-run=client -o yaml > namespace.yml

# scale a deployment
kubectl scale deployment <DEPLOYMENT_NAME> -n <NAMESPACE_NAME> --replicas <DESIRED_REPLICAS_COUNT>

# list ingress resources
kubectl get ingress -n <DESIRED_NAMESPACE>

# describe different kubernetes resources
kubectl describe po <POD_NAME> -n <NAMESPACE_NAME>
kubectl describe ing <INGRESS_NAME> -n <NAMESPACE_NAME>

# get logs from a particular pod
kubectl logs <POD_NAME>
# continuously stream log stream from a pod
kubectl logs <POD_NAME> -f
# get logs from a particular container in a pod
kubectl logs <POD_NAME> -c <CONTAINER_NAME>

# deploy a manifest to Kubernetes for a desired namespace
kubectl apply -f <YAML_FILE> -n <NAMESPACE_NAME>

# get services from all namespaces
kubectl get svc -A

# Add helm Repository
helm repo add <alias> <repository_url>

# Update repository feed
helm repo update

# install a helm chart
helm install -g basta/ingress-nginx --namespace <desired_namespace> --create-namespace

# list all helm releases in the current cluster
helm list -A

# create a custom helm chart
helm chart create <PATH>

# lint a custom helm chart
helm lint <PATH>

# package a helm chart
helm package <PATH>

# scan docker container locally
docker scan <DOCKER_IMAGE_NAME>:<DOCKER_IMAGE_TAG>

# build docker image locally
docker build . -t <YOUR_REGISTRY_PREFIX>/<DOCKER_IMAGE_NAME>:<DOCKER_IMAGE_TAG>

# push docker image
docker push <YOUR_REGISTRY_PREFIX>/<DOCKER_IMAGE_NAME>:<DOCKER_IMAGE_TAG>

# authenticate with Azure Container Registry (ACR)
az acr login -n <ACR_NAME>
```

## Contact

Thorsten Hans: [✉️](mailto:thorsten.hans@thinktecture.com) [🐦](https://twitter.com/ThorstenHans)
