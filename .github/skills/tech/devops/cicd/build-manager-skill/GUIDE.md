# Build Manager Skill

> **Category:** Tech Skills

## Overview

Use when managing build pipelines, dependency resolution, artifact creation, and version management.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [build-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
build-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@build-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure CI/CD pipelines with build, test, scan, and deploy stages
- Execute deployment strategies: rolling, blue-green, canary, and progressive rollout
- Manage environment promotion workflows with approval gates
- Validate deployment health through automated smoke tests and metric checks

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
