# Terraform State Manager Skill

> **Category:** Tech Skills > DevOps > Terraform

## Overview

Manages Terraform state including remote backends, state locking, state migration, and state file security for team collaboration

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [terraform-state-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
terraform-state-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@terraform-state-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure S3, GCS, or Azure Blob remote backends
- Implement state locking with DynamoDB or equivalent
- Manage workspaces for environment separation
- Migrate state between backends safely

## Technology Standards Applied

- **Remote Backends**: Backend configuration and security
- **State Locking**: Concurrent access prevention
- **State Security**: Encryption and access control for state files