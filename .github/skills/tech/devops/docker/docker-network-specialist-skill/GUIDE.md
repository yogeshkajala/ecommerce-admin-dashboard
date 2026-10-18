# Docker Network Specialist Skill

> **Category:** Tech Skills > DevOps > Docker

## Overview

Configures Docker networking with bridge, overlay, and macvlan networks for container communication and isolation

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [docker-network-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
docker-network-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@docker-network-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure bridge networks for single-host isolation
- Create overlay networks for multi-host communication
- Implement macvlan for direct network attachment
- Set up DNS-based service discovery

## Technology Standards Applied

- **Docker Networking**: Network driver selection and configuration
- **Network Isolation**: Container network segmentation patterns
- **DNS Resolution**: Embedded DNS for service discovery