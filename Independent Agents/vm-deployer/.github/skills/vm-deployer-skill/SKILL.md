---
name: vm-deployer-skill
description: "VM Deployer skill -- Use when deploying applications to virtual machines via Docker, including image builds, transfers, container orchestration, and health checks."
---

# VM Deployer Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for VM deployment operations. This skill encapsulates Docker containerization, SSH-based deployment, and health check verification patterns.

## When to Use

- When deploying applications to virtual machines via Docker containers
- When building Docker images and transferring to target VMs
- When configuring container orchestration and port mappings
- When performing health checks and rollback procedures
- When managing deployment environments (dev, staging, production)

## Capabilities

- Build Docker images from project Dockerfiles with multi-stage builds
- Transfer images to VMs via direct SCP or Docker registry push
- Deploy containers with proper port mapping, volumes, and environment variables
- Execute health checks to verify deployment success
- Perform rollback procedures when health checks fail
- Manage environment-specific configurations (dev, staging, production)
- Configure container restart policies and resource limits
- Set up log aggregation and monitoring for deployed containers

## Deployment Strategies

| Strategy | Use Case | Risk |
|----------|----------|------|
| Rolling | Zero-downtime updates | Medium -- partial rollout |
| Blue-Green | Instant switchover | Low -- full rollback available |
| Canary | Gradual traffic shift | Low -- minimal blast radius |
| Recreate | Simple replacement | High -- downtime during switch |

## Procedure

1. Receive deployment request -- identify application, target VM, and environment
2. Collect VM details (host, username, SSH port, deployment path)
3. Validate inputs and verify Docker is available locally
4. Build Docker image from project Dockerfile
5. Transfer image to target VM (SCP or registry push)
6. Stop existing container if running (with graceful shutdown)
7. Start new container with configured port mappings and environment
8. Execute health check against deployed application
9. If health check fails: rollback to previous image and report failure
10. If health check passes: clean up old images and report success

## Output Format

Return structured results:

- **Deployment Summary**: application, target VM, environment, image tag
- **Build Status**: image name, tag, size, build duration
- **Container Status**: container ID, port mappings, resource limits
- **Health Check**: endpoint, response code, response time, status
- **Quality Gate**: PASS/FAIL (health check must return 200 OK)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **Docker Best Practices** | Multi-stage builds, minimal images, non-root users |
| **12-Factor App** | Config in environment, stateless processes, disposability |
| **SSH Hardening** | Key-based auth, no root login, restricted commands |
| **Health Check Patterns** | Liveness, readiness, startup probes for container health |
