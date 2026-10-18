# GitHub Actions Self-Hosted Runner Specialist Skill

> **Category:** Tech Skills > DevOps > GitHub Actions

## Overview

Deploys and manages GitHub Actions self-hosted runners with autoscaling, security hardening, and runner groups for enterprise use

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [gha-self-hosted-runner-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
gha-self-hosted-runner-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@gha-self-hosted-runner-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Deploy self-hosted runners on Linux, macOS, Windows
- Configure actions-runner-controller for Kubernetes
- Implement runner autoscaling based on demand
- Secure runners with proper isolation

## Technology Standards Applied

- **Self-Hosted Runners**: Runner deployment and management
- **ARC**: Actions Runner Controller for Kubernetes
- **Runner Security**: Self-hosted runner security hardening