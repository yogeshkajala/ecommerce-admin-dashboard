# Post Migration Ops Skill

> **Category:** Domain Skills

## Overview

Use when setting up post-migration operations -- monitoring, cost optimization, performance tuning, and documentation.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [post-migration-ops-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
post-migration-ops-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@post-migration-ops` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze cloud spending across services, teams, and environments
- Identify cost optimization opportunities: idle resources, over-provisioning, licensing waste
- Model ROI scenarios for technology investments and migrations
- Track budget utilization with alerting on threshold breaches

## Industry Standards Applied

- **AWS 7R Migration**: Migration strategies: rehost, replatform, refactor, repurchase, retire, retain, relocate
- **TOGAF ADM**: Architecture development method for transformation initiatives
- **Strangler Fig Pattern**: Incremental migration pattern for legacy system replacement
