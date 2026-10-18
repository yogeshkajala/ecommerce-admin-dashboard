# Migration Assessor Skill

> **Category:** Domain Skills

## Overview

Use when assessing workloads for cloud migration including discovery, compatibility checking, cost modeling, and risk evaluation.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [migration-assessor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
migration-assessor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@migration-assessor` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze cloud spending across services, teams, and environments
- Identify cost optimization opportunities: idle resources, over-provisioning, licensing waste
- Model ROI scenarios for technology investments and migrations
- Track budget utilization with alerting on threshold breaches

## Industry Standards Applied

- **AWS 7R Migration**: Migration strategies: rehost, replatform, refactor, repurchase, retire, retain, relocate
- **TOGAF ADM**: Architecture development method for transformation initiatives
- **Strangler Fig Pattern**: Incremental migration pattern for legacy system replacement
