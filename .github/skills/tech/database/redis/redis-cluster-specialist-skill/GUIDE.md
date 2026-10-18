# Redis Cluster Specialist Skill

> **Category:** Tech Skills > Database > Redis

## Overview

Deploys and manages Redis Cluster for horizontal scaling including slot management, resharding, and client configuration

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [redis-cluster-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
redis-cluster-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@redis-cluster-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Deploy Redis Cluster with proper topology
- Manage hash slot distribution and resharding
- Configure client-side routing with smart clients
- Handle cluster failover and recovery

## Technology Standards Applied

- **Redis Cluster**: Cluster specification and deployment
- **Hash Slots**: Slot management and distribution
- **Client Routing**: MOVED and ASK redirect handling