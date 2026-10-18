---
description: "Use when deploying applications to VMs, managing containers, building Docker images, or performing infrastructure operations."
applyTo: "**/Dockerfile*"
---

# Deployment Standards

## Docker Image Build
- Use multi-stage builds to minimize final image size
- Pin base image versions (never use `latest` tag)
- Use official or verified images only
- Order instructions from least to most frequently changing (layer caching)
- Run containers as non-root user (`USER appuser`)
- Never store secrets in images or environment variables in Dockerfile
- Use `.dockerignore` to exclude sensitive files and build artifacts
- Scan images for CVEs before deployment
- Use `COPY` not `ADD` unless extracting archives
- One process per container
- Use `HEALTHCHECK` instruction for container health
- Set explicit `WORKDIR` before COPY/RUN commands
- Clean up package manager caches in the same layer as install
- Use `EXPOSE` to document container ports
- Pass runtime config via environment variables (never hardcode)

## Pre-Deployment
- All tests must pass before deployment
- Security scan must show 0 critical/high findings
- Docker image must build successfully
- Deployment plan must be documented for production

## Deployment Process
- Use immutable deployments (new container, not in-place update)
- Always maintain rollback capability (keep previous image)
- Deploy to staging first; verify before production
- Use health checks to confirm successful deployment

## Health Checks
- Every deployed service must expose a `/health` endpoint
- Health check must verify: application running, dependencies reachable
- Deployment is only "success" after health check passes
- If health check fails within 60s, auto-rollback to previous version

## Container Management
- Map container ports explicitly (never use host networking in production)
- Set resource limits (CPU, memory) for all containers
- Configure restart policy: `unless-stopped` for production
- Persist data via named volumes, never container filesystem
- Use log drivers for centralized logging

## SSH/VM Access
- Use key-based SSH authentication only
- Never use root for SSH connections
- Restrict SSH access to deployment service accounts
- Log all deployment actions with timestamps and operator

## Post-Deployment
- Verify health check passes
- Run smoke tests against deployed service
- Monitor error rates for 15 minutes post-deploy
- Update deployment log with version, timestamp, operator
