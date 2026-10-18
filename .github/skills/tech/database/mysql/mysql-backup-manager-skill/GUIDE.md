# MySQL Backup Manager Skill

> **Category:** Tech Skills > Database > MySQL

## Overview

Implements MySQL backup and recovery with mysqldump, mysqlpump, and Percona XtraBackup for reliable data protection

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [mysql-backup-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
mysql-backup-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@mysql-backup-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure mysqldump for logical backups
- Set up Percona XtraBackup for hot physical backups
- Implement binary log-based point-in-time recovery
- Automate backup schedules with monitoring

## Technology Standards Applied

- **mysqldump**: Logical backup tool for MySQL
- **XtraBackup**: Hot physical backup for InnoDB
- **PITR**: Point-in-time recovery with binary logs