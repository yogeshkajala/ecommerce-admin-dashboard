# MongoDB Backup Manager Skill

> **Category:** Tech Skills > Database > MongoDB

## Overview

Implements MongoDB backup strategies with mongodump, filesystem snapshots, and Atlas backup for data protection and recovery

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [mongodb-backup-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
mongodb-backup-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@mongodb-backup-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure mongodump for logical backups
- Implement filesystem snapshots for physical backups
- Set up oplog-based point-in-time recovery
- Use Atlas backup for cloud deployments

## Technology Standards Applied

- **mongodump**: Logical backup tool for MongoDB
- **Atlas Backup**: Cloud-native backup for MongoDB Atlas
- **Oplog**: Point-in-time recovery with operation log