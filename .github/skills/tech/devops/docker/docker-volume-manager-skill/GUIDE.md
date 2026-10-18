# Docker Volume Manager Skill

> **Category:** Tech Skills > DevOps > Docker

## Overview

Manages Docker storage with named volumes, bind mounts, and volume drivers for persistent data management in containerized applications

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [docker-volume-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
docker-volume-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@docker-volume-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure named volumes for persistent data
- Set up bind mounts for development workflows
- Use volume drivers for cloud storage integration
- Implement volume backup and restore procedures

## Technology Standards Applied

- **Docker Storage**: Volume types and driver selection
- **Data Persistence**: Persistent storage patterns for containers
- **Backup**: Volume backup and restore procedures