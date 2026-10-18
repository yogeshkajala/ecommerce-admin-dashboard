# Redis Sentinel Manager Skill

> **Category:** Tech Skills > Database > Redis

## Overview

Deploys and manages Redis Sentinel for automatic failover, monitoring, and notification in high availability Redis deployments

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [redis-sentinel-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
redis-sentinel-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@redis-sentinel-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Deploy Sentinel nodes for quorum-based failover
- Configure automatic failover with proper thresholds
- Set up client connections through Sentinel
- Monitor Redis instance health and replication

## Technology Standards Applied

- **Redis Sentinel**: High availability deployment and configuration
- **Quorum**: Sentinel quorum and failover consensus
- **Client Configuration**: Sentinel-aware client connection patterns