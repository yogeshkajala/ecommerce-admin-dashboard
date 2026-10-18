# Nginx Container Specialist Skill

> **Category:** Tech Skills > Others > Nginx

## Overview

Configures Nginx in Docker and Kubernetes environments with proper image optimization, config injection, and health probes

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [nginx-container-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
nginx-container-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@nginx-container-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Build optimized Nginx Docker images
- Inject configuration with Docker volumes or ConfigMaps
- Configure health probes for orchestrators
- Implement sidecar patterns for Nginx

## Technology Standards Applied

- **Nginx Docker**: Container deployment patterns
- **ConfigMap**: Kubernetes configuration injection
- **Health Probes**: Container health check configuration