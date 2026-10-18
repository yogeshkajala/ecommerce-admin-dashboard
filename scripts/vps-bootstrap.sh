#!/usr/bin/env bash
# ─────────────────────────────────────────────────────────────────────────────
#  VPS Bootstrap Script — Hostinger VPS One-Time Setup
#  Run from your LOCAL machine:
#
#    chmod +x scripts/vps-bootstrap.sh
#    ssh YOUR_USER@YOUR_VPS_IP "bash -s" < scripts/vps-bootstrap.sh
#
#  OR interactively:
#    ssh YOUR_USER@YOUR_VPS_IP
#    bash <(curl -s https://raw.githubusercontent.com/yogeshverma/ecommerce-admin-dashboard/main/scripts/vps-bootstrap.sh)
#
#  What this script does:
#    1. Creates /opt/ecommerce-admin/{staging,production} directory structure
#    2. Ensures the 'traefik-public' Docker network exists (shared with Traefik)
#    3. Copies docker-compose files to VPS deployment paths
#    4. Creates a 'deploy' system user with Docker access (security best practice)
#    5. Generates SSH key pair for GitHub Actions → VPS authentication
#    6. Prints next steps including GitHub Secrets to configure
#
#  Prerequisites on VPS (Hostinger Ubuntu/Debian):
#    - Docker installed (docker.io or docker-ce)
#    - Docker Compose plugin installed (docker compose v2)
#    - Traefik container running and connected to 'traefik-public' network
#    - Your SSH access to VPS as root or sudo user
# ─────────────────────────────────────────────────────────────────────────────

set -euo pipefail

# ─── Configuration ────────────────────────────────────────────────────────────
DEPLOY_BASE="/opt/ecommerce-admin"
DEPLOY_USER="deploy"
TRAEFIK_NETWORK="traefik-public"
REPO_OWNER="yogeshverma"
APP_NAME="ecommerce-admin"

# ─── Colors ───────────────────────────────────────────────────────────────────
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
RED='\033[0;31m'
NC='\033[0m' # No Color

log()     { echo -e "${GREEN}[✓]${NC} $1"; }
info()    { echo -e "${BLUE}[ℹ]${NC} $1"; }
warn()    { echo -e "${YELLOW}[!]${NC} $1"; }
section() { echo -e "\n${BLUE}━━━ $1 ━━━${NC}"; }

section "EcommerceAdmin VPS Bootstrap"
info "Setting up on: $(hostname) ($(uname -m))"
info "Deployment base: $DEPLOY_BASE"

# ─── 1. Create directory structure ────────────────────────────────────────────
section "1. Directory Structure"

mkdir -p "$DEPLOY_BASE/staging"
mkdir -p "$DEPLOY_BASE/production"
mkdir -p "$DEPLOY_BASE/shared/logs"

chmod 750 "$DEPLOY_BASE"
log "Created $DEPLOY_BASE/{staging,production,shared}"

# ─── 2. Ensure traefik-public Docker network exists ───────────────────────────
section "2. Docker Network"

if docker network ls --format '{{.Name}}' | grep -q "^${TRAEFIK_NETWORK}$"; then
  log "Network '${TRAEFIK_NETWORK}' already exists — skipping"
else
  docker network create --driver bridge "$TRAEFIK_NETWORK"
  log "Created Docker network: $TRAEFIK_NETWORK"
fi

info "Current networks:"
docker network ls --filter "name=traefik" --format "  {{.Name}} ({{.Driver}})"

# ─── 3. Create 'deploy' system user ───────────────────────────────────────────
section "3. Deploy User"

if id "$DEPLOY_USER" &>/dev/null; then
  warn "User '$DEPLOY_USER' already exists — skipping creation"
else
  useradd --system --shell /bin/bash --home-dir "$DEPLOY_BASE" \
          --no-create-home --comment "EcommerceAdmin deploy user" "$DEPLOY_USER"
  log "Created system user: $DEPLOY_USER"
fi

# Add deploy user to docker group (allows running docker without sudo)
usermod -aG docker "$DEPLOY_USER"
log "Added $DEPLOY_USER to docker group"

# Set ownership of deployment directories
chown -R "$DEPLOY_USER:$DEPLOY_USER" "$DEPLOY_BASE"
log "Set ownership of $DEPLOY_BASE to $DEPLOY_USER"

# ─── 4. Generate GitHub Actions SSH key pair ──────────────────────────────────
section "4. SSH Key for GitHub Actions"

SSH_DIR="$DEPLOY_BASE/.ssh"
KEY_FILE="$SSH_DIR/github_actions_ed25519"

mkdir -p "$SSH_DIR"
chmod 700 "$SSH_DIR"

if [ -f "$KEY_FILE" ]; then
  warn "SSH key already exists at $KEY_FILE — skipping generation"
else
  ssh-keygen -t ed25519 -C "github-actions@datasoftio.com" \
             -f "$KEY_FILE" -N "" -q
  log "Generated SSH key pair: $KEY_FILE"
fi

# Add public key to authorized_keys for the deploy user
touch "$SSH_DIR/authorized_keys"
if ! grep -qF "$(cat "${KEY_FILE}.pub")" "$SSH_DIR/authorized_keys" 2>/dev/null; then
  cat "${KEY_FILE}.pub" >> "$SSH_DIR/authorized_keys"
  log "Added public key to authorized_keys"
else
  warn "Public key already in authorized_keys — skipping"
fi

chmod 600 "$SSH_DIR/authorized_keys"
chown -R "$DEPLOY_USER:$DEPLOY_USER" "$SSH_DIR"

# ─── 5. Copy docker-compose files to deployment paths ─────────────────────────
section "5. Docker Compose Files"

warn "You need to manually copy docker-compose files to the VPS."
info "Run from your LOCAL machine (project root):"
echo ""
echo "  # Copy base + environment-specific compose files to staging"
echo "  scp docker-compose.yml docker-compose.staging.yml \\"
echo "      ${DEPLOY_USER}@YOUR_VPS_IP:${DEPLOY_BASE}/staging/"
echo ""
echo "  # Copy base + environment-specific compose files to production"
echo "  scp docker-compose.yml docker-compose.prod.yml \\"
echo "      ${DEPLOY_USER}@YOUR_VPS_IP:${DEPLOY_BASE}/production/"
echo ""

# ─── 6. Print GitHub Secrets to configure ────────────────────────────────────
section "6. GitHub Secrets Configuration"

PRIVATE_KEY=$(cat "$KEY_FILE")
VPS_IP=$(curl -s ifconfig.me 2>/dev/null || hostname -I | awk '{print $1}')

echo ""
echo -e "${YELLOW}━━━ Copy these values into GitHub Secrets ━━━${NC}"
echo ""
echo -e "${BLUE}Go to: https://github.com/${REPO_OWNER}/${APP_NAME}/settings/environments${NC}"
echo ""
echo "── Environment: staging ──────────────────────────────────────────────"
echo ""
echo "Secret: SSH_HOST"
echo "Value:  $VPS_IP"
echo ""
echo "Secret: SSH_USER"
echo "Value:  $DEPLOY_USER"
echo ""
echo "Secret: SSH_KEY"
echo "Value: (copy everything between the lines below)"
echo "┌────────────────────────────────────────────────────────────────────┐"
echo "$PRIVATE_KEY"
echo "└────────────────────────────────────────────────────────────────────┘"
echo ""
echo "Secret: STAGING_ENV_FILE"
echo "Value:  (contents of your staging .env file — based on .env.example)"
echo ""
echo "── Environment: production ───────────────────────────────────────────"
echo "(Same SSH_HOST, SSH_USER, SSH_KEY — or different VPS for prod isolation)"
echo ""
echo "Secret: PROD_ENV_FILE"
echo "Value:  (contents of your production .env file)"
echo ""

# ─── 7. Verify existing Traefik integration ───────────────────────────────────
section "7. Traefik Integration Check"

if docker ps --format '{{.Names}}' | grep -qi traefik; then
  TRAEFIK_CONTAINER=$(docker ps --format '{{.Names}}' | grep -i traefik | head -1)
  log "Traefik container found: $TRAEFIK_CONTAINER"

  # Check if Traefik is connected to traefik-public network
  if docker inspect "$TRAEFIK_CONTAINER" \
       --format '{{range $k, $v := .NetworkSettings.Networks}}{{$k}} {{end}}' \
     | grep -q "$TRAEFIK_NETWORK"; then
    log "Traefik is connected to '$TRAEFIK_NETWORK' network ✅"
  else
    warn "Traefik is NOT connected to '$TRAEFIK_NETWORK'. Connect it:"
    echo "  docker network connect $TRAEFIK_NETWORK $TRAEFIK_CONTAINER"
  fi
else
  warn "No Traefik container found running. Ensure Traefik is started before deploying."
fi

# ─── 8. DNS reminder ─────────────────────────────────────────────────────────
section "8. DNS Configuration Reminder"

echo ""
info "Ensure these DNS A records point to this VPS ($VPS_IP):"
echo ""
echo "  datasoftio.com          A  $VPS_IP"
echo "  www.datasoftio.com      A  $VPS_IP"
echo "  staging.datasoftio.com  A  $VPS_IP"
echo ""
info "DNS changes can take up to 48h to propagate."
info "Verify with: dig +short staging.datasoftio.com"

# ─── Done ─────────────────────────────────────────────────────────────────────
section "Bootstrap Complete"
log "VPS is ready for EcommerceAdmin deployments!"
echo ""
echo "Next steps:"
echo "  1. Copy the SSH private key to GitHub Secrets (shown above)"
echo "  2. Copy docker-compose files to the VPS (commands shown above)"
echo "  3. Configure staging .env and prod .env as GitHub Secrets"
echo "  4. Set up GitHub Environments with required reviewer for production"
echo "  5. Create GitHub repo and push code"
echo "  6. Push to main branch → CI/CD will trigger automatically"
echo ""
