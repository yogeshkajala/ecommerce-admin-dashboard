# PostgreSQL Backup Manager Skill

> **Category:** Tech Skills > Database > PostgreSQL

## Overview

Implements PostgreSQL backup and recovery strategies with pg_dump, pg_basebackup, and PITR for data protection and disaster recovery

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [postgresql-backup-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
postgresql-backup-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@postgresql-backup-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure pg_dump for logical backups
- Set up pg_basebackup for physical backups
- Implement PITR with continuous WAL archiving
- Automate backup schedules with pgBackRest

## Technology Standards Applied

- **pg_dump**: Logical backup and restore patterns
- **pgBackRest**: Enterprise backup management tool
- **PITR**: Point-in-time recovery with WAL archiving