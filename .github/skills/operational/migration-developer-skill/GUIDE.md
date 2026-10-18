# Migration Developer Skill

> **Category:** Domain Skills

## Overview

Use when implementing legacy migration including code translation, data conversion, interface adaptation, and batch job migration.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [migration-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
migration-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@migration-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness

## Industry Standards Applied

- **AWS 7R Migration**: Migration strategies: rehost, replatform, refactor, repurchase, retire, retain, relocate
- **TOGAF ADM**: Architecture development method for transformation initiatives
- **Strangler Fig Pattern**: Incremental migration pattern for legacy system replacement
