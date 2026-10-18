# Docker Registry Manager Skill

> **Category:** Tech Skills > DevOps > Docker

## Overview

Manages Docker registries including Harbor, ECR, and ACR with image lifecycle policies, security scanning, and access control

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [docker-registry-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
docker-registry-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@docker-registry-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Deploy Harbor for private registry management
- Configure ECR and ACR lifecycle policies
- Set up image signing with cosign
- Implement role-based access control

## Technology Standards Applied

- **OCI Distribution**: Container registry specification
- **Image Signing**: Supply chain security with cosign
- **RBAC**: Registry access control patterns