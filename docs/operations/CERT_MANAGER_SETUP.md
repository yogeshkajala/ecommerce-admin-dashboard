# Automated SSL/TLS Setup for K3s (Let's Encrypt)

To automatically provision SSL certificates for domains hosted on our K3s cluster (like `datasoftio.com`), we use **cert-manager** along with **Let's Encrypt**.

## 1. Install cert-manager on the Host VPS
SSH into the Hostinger VPS where your K3s cluster is running, and run the following command to install `cert-manager` directly from the official manifests:

```bash
kubectl apply -f https://github.com/cert-manager/cert-manager/releases/download/v1.14.4/cert-manager.yaml
```

Wait a few moments for the cert-manager pods to spin up:
```bash
kubectl get pods -n cert-manager
```

## 2. Create the Let's Encrypt ClusterIssuer
Once cert-manager is running, we need to configure a `ClusterIssuer` to tell cert-manager how to request certificates from Let's Encrypt. 

Create a file named `letsencrypt-prod-issuer.yaml` on the host:

```yaml
apiVersion: cert-manager.io/v1
kind: ClusterIssuer
metadata:
  name: letsencrypt-prod
spec:
  acme:
    # The ACME server URL
    server: https://acme-v02.api.letsencrypt.org/directory
    # Email address used for ACME registration
    email: contact@datasoftio.com
    # Name of a secret used to store the ACME account private key
    privateKeySecretRef:
      name: letsencrypt-prod-key
    # Enable the HTTP-01 challenge provider
    solvers:
    - http01:
        ingress:
          class: traefik
```

Apply this to your cluster:
```bash
kubectl apply -f letsencrypt-prod-issuer.yaml
```

## 3. How the Apps Use It
Any app deployed to the cluster (like our `datasoftio-website`) simply adds a few annotations to its `Ingress` resource:

```yaml
  annotations:
    cert-manager.io/cluster-issuer: "letsencrypt-prod"
    traefik.ingress.kubernetes.io/router.entrypoints: "websecure"
    traefik.ingress.kubernetes.io/router.tls: "true"
```
And a TLS block in the spec:
```yaml
spec:
  tls:
  - hosts:
    - datasoftio.com
    secretName: datasoftio-tls-secret
```

cert-manager will automatically see this Ingress, communicate with Let's Encrypt via HTTP-01 challenges, generate the certificate, and store it in the `datasoftio-tls-secret`. Traefik will then seamlessly serve your site over HTTPS!
-e 
Reviewed and approved by DevOps-Agent.
