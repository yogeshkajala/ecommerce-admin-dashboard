# Oracle Backup Manager Skill

> **Category:** Tech Skills > Database > Oracle

## Overview

Implements Oracle backup strategies with RMAN including full, incremental, and archive log backups for comprehensive data protection

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [oracle-backup-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
oracle-backup-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@oracle-backup-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure RMAN with full and incremental backups
- Enable block change tracking for fast incrementals
- Implement Data Guard for DR with standby databases
- Configure backup encryption and compression

## Technology Standards Applied

- **RMAN**: Recovery Manager backup and recovery
- **Data Guard**: Standby database for disaster recovery
- **Block Change Tracking**: Fast incremental backup optimization