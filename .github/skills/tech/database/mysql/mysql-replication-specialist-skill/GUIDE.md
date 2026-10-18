# MySQL Replication Specialist Skill

> **Category:** Tech Skills > Database > MySQL

## Overview

Configures MySQL replication including GTID-based replication, group replication, and InnoDB Cluster for high availability

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [mysql-replication-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
mysql-replication-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@mysql-replication-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure GTID-based asynchronous replication
- Set up MySQL Group Replication for multi-master
- Deploy InnoDB Cluster with MySQL Shell
- Monitor replication lag and consistency

## Technology Standards Applied

- **GTID Replication**: Transaction-based replication configuration
- **InnoDB Cluster**: Integrated high availability solution
- **MySQL Router**: Connection routing and failover