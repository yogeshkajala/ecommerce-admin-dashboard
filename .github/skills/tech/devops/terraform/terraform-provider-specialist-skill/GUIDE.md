# Terraform Provider Specialist Skill

> **Category:** Tech Skills > DevOps > Terraform

## Overview

Configures and optimizes Terraform providers for AWS, Azure, GCP, and Kubernetes with proper authentication and feature management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [terraform-provider-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
terraform-provider-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@terraform-provider-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure AWS, Azure, and GCP providers
- Implement multi-region deployments with provider aliases
- Manage provider version constraints
- Configure authentication with OIDC and managed identity

## Technology Standards Applied

- **Provider Configuration**: Authentication and feature configuration
- **Version Constraints**: Provider version pinning best practices
- **Multi-Region**: Provider alias patterns for multi-region