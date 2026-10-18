# Azure DevOps Specialist Skill

> **Category:** Tech Skills > DevOps > Azure

## Overview

Configures Azure DevOps for CI/CD with pipelines, repos, boards, and artifacts for complete software delivery lifecycle management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [azure-devops-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
azure-devops-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@azure-devops-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Create YAML pipelines for CI/CD automation
- Configure branch policies and pull request flows
- Set up Azure Artifacts for package management
- Implement service connections for deployments

## Technology Standards Applied

- **Azure Pipelines**: YAML pipeline syntax and patterns
- **Branch Policies**: Code review and build validation
- **Environments**: Deployment targets with approvals