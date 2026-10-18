# PostgreSQL Replication Specialist Skill

> **Category:** Tech Skills > Database > PostgreSQL

## Overview

Configures PostgreSQL replication including streaming replication, logical replication, and high availability with Patroni or pg_auto_failover

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [postgresql-replication-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
postgresql-replication-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@postgresql-replication-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure streaming replication with synchronous mode
- Set up logical replication with publication/subscription
- Implement Patroni for automatic failover
- Monitor replication lag and health

## Technology Standards Applied

- **Streaming Replication**: Physical replication configuration and monitoring
- **Logical Replication**: Publication/subscription patterns
- **Patroni**: High availability and automatic failover