# GitHub Actions Security Specialist Skill

> **Category:** Tech Skills > DevOps > GitHub Actions

## Overview

Implements security best practices for GitHub Actions including secret management, OIDC authentication, and supply chain security

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [gha-security-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
gha-security-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@gha-security-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure OIDC for passwordless cloud authentication
- Pin actions to commit SHAs for supply chain security
- Implement minimal permissions with permissions key
- Set up Dependabot for action version updates

## Technology Standards Applied

- **Actions Security**: GitHub Actions security hardening guide
- **OIDC**: OpenID Connect for cloud authentication
- **Supply Chain**: Action pinning and verification