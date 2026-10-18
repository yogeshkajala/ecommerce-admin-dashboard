# Data Integrity Validator Skill

> **Category:** Tech Skills

## Overview

Use when validating migrated data integrity including row counts, checksums, referential integrity, and business value verification.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [data-integrity-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
data-integrity-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@data-integrity-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze query execution plans and optimize for performance
- Design database schemas following normalization and indexing best practices
- Configure backup strategies with recovery point and time objectives
- Manage data replication for high availability and disaster recovery

## Industry Standards Applied

- **ACID Principles**: Transaction guarantees: Atomicity, Consistency, Isolation, Durability
- **CAP Theorem**: Distributed database trade-offs: Consistency, Availability, Partition tolerance
- **Database Normalization**: Normal forms (1NF-5NF) for relational data integrity
