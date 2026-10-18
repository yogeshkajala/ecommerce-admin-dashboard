# Core Banking Migration Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when planning and executing core banking system migrations including account data migration, transaction history preservation, integration rewiring, and parallel run validation between legacy and target platforms.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [core-banking-migration-skill-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
core-banking-migration-skill-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@core-banking-migration-skill` agent from the Independent Agents catalogue.

## Key Capabilities

- Map legacy core banking data models to target platform schema
- Design incremental migration waves by product, branch, and customer segment
- Execute parallel transaction processing with real-time comparison
- Validate account balance reconciliation between legacy and target systems

## Industry Standards Applied

- **ISO 20022**: Universal financial messaging standard for payment and reporting
- **BIAN (Banking Industry Architecture Network)**: Service-oriented banking architecture reference model
- **Basel III**: Operational risk considerations during system migration