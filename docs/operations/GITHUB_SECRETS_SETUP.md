# GitHub Secrets Setup for CI/CD

To enable autonomous deployments via GitHub Actions, you must add the following **Repository Secrets** to the GitHub repository containing your application (`ecommerce-admin-dashboard`).

## Navigation
1. Open the repository on GitHub.
2. Go to **Settings** > **Secrets and variables** > **Actions**.
3. Click **New repository secret**.

## Required Secrets

1. **`VPS_HOST`**
   - **Value:** The public IP address of your host VPS (e.g., `187.127.131.114`).

2. **`VPS_USERNAME`**
   - **Value:** The SSH username for the VPS (e.g., `root`).

3. **`VPS_SSH_KEY`**
   - **Value:** The **private** SSH key (e.g., the contents of `~/.ssh/id_rsa` or `~/.ssh/id_ed25519`) that corresponds to a public key authorized on the VPS (`/root/.ssh/authorized_keys`). Ensure you copy the entire block including the `-----BEGIN` and `-----END` headers.

## Expected Outcome
Once these three secrets are saved, any push to the `main` branch modifying the `apps/datasoftio-website/` directory will automatically trigger the CI/CD pipeline, building the Docker image and rolling it out to the K3s cluster on the VPS with zero downtime.
