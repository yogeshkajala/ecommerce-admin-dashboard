# Docker Compose Specialist Skill

> **Category:** Tech Skills > DevOps > Docker

## Overview

Orchestrates multi-container applications with Docker Compose including service dependencies, networking, and volume management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [docker-compose-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
docker-compose-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@docker-compose-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Define multi-service applications with compose.yaml
- Configure service dependencies with depends_on and healthcheck
- Set up custom networks for service isolation
- Manage volumes for persistent data

## Technology Standards Applied

- **Compose Specification**: Official Compose file format and features
- **Service Discovery**: DNS-based service discovery in Compose
- **Health Checks**: Container health check configuration