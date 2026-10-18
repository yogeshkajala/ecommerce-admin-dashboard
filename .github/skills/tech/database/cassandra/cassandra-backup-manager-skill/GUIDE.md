# Cassandra Backup Manager Skill

> **Category:** Tech Skills > Database > Cassandra

## Overview

Implements Cassandra backup and restore strategies with snapshots, incremental backups, and Medusa for data protection

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [cassandra-backup-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
cassandra-backup-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@cassandra-backup-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Create snapshots with nodetool snapshot
- Configure incremental backups
- Use Medusa for automated backup management
- Implement backup verification

## Technology Standards Applied

- **Cassandra Backups**: Snapshot and incremental backup patterns
- **Medusa**: Automated backup management for Cassandra
- **Restore**: Restore procedures and validation