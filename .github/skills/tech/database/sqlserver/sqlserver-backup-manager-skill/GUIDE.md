# SQL Server Backup Manager Skill

> **Category:** Tech Skills > Database > SQL Server

## Overview

Implements SQL Server backup strategies with full, differential, and log backups for comprehensive data protection and PITR

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [sqlserver-backup-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
sqlserver-backup-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@sqlserver-backup-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure full, differential, and transaction log backups
- Implement backup compression and encryption
- Set up backup to Azure Blob Storage
- Manage backup retention and cleanup

## Technology Standards Applied

- **SQL Server Backup**: Backup strategy and recovery models
- **Backup Compression**: Compression and encryption settings
- **Azure Backup**: SQL Server backup to Azure Blob Storage