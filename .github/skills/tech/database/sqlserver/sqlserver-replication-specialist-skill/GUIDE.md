# SQL Server Replication Specialist Skill

> **Category:** Tech Skills > Database > SQL Server

## Overview

Configures SQL Server replication and Always On availability groups for high availability and disaster recovery

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [sqlserver-replication-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
sqlserver-replication-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@sqlserver-replication-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure Always On availability groups with synchronous commit
- Set up transactional replication for data distribution
- Implement distributed AG for multi-region HA
- Configure read replicas for read scale-out

## Technology Standards Applied

- **Always On AG**: Availability group configuration and management
- **Transactional Replication**: Data distribution and subscriber management
- **Distributed AG**: Cross-region availability group patterns