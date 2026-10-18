# Legacy Data Migrator Skill

> **Category:** Tech Skills

## Overview

Migrate data from legacy formats (VSAM, flat files, IMS) to modern databases.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [legacy-data-migrator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
legacy-data-migrator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@legacy-data-migrator` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze query execution plans and optimize for performance
- Design database schemas following normalization and indexing best practices
- Configure backup strategies with recovery point and time objectives
- Manage data replication for high availability and disaster recovery

## Industry Standards Applied

- **AWS 7R Migration**: Migration strategies: rehost, replatform, refactor, repurchase, retire, retain, relocate
- **TOGAF ADM**: Architecture development method for transformation initiatives
- **Strangler Fig Pattern**: Incremental migration pattern for legacy system replacement
