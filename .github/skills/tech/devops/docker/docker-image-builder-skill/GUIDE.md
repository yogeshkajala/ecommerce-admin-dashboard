# Docker Image Builder Skill

> **Category:** Tech Skills > DevOps > Docker

## Overview

Creates optimized Docker images with multi-stage builds, layer caching, and security scanning for production container deployments

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [docker-image-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
docker-image-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@docker-image-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Build multi-stage Dockerfiles for optimal image size
- Configure layer caching for faster builds
- Implement build arguments and secrets handling
- Scan images with Trivy or Docker Scout

## Technology Standards Applied

- **Dockerfile Best Practices**: Official Dockerfile optimization guidelines
- **Image Security**: Vulnerability scanning and minimal base images
- **Build Cache**: Layer caching strategies for CI/CD