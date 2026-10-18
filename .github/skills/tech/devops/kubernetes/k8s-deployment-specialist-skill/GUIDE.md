# K8s Deployment Specialist Skill

> **Category:** Tech Skills > DevOps > Kubernetes

## Overview

Implements Kubernetes deployments with rolling updates, resource management, and pod lifecycle configuration for production workloads

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [k8s-deployment-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
k8s-deployment-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@k8s-deployment-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure Deployments with proper resource requests and limits
- Implement rolling update and recreate strategies
- Set up readiness, liveness, and startup probes
- Configure pod disruption budgets for maintenance

## Technology Standards Applied

- **K8s Deployments**: Deployment configuration best practices
- **Resource Management**: CPU and memory requests/limits guidelines
- **Health Probes**: Probe configuration for pod lifecycle