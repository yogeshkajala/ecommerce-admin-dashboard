# Cutover Planner Skill

> **Category:** Domain Skills

## Overview

Use when creating detailed cutover plans for legacy migration including timelines, checkpoints, task sequences, and rollback decision points.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [cutover-planner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
cutover-planner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@cutover-planner` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness

## Industry Standards Applied

- **AWS 7R Migration**: Migration strategies: rehost, replatform, refactor, repurchase, retire, retain, relocate
- **TOGAF ADM**: Architecture development method for transformation initiatives
- **Strangler Fig Pattern**: Incremental migration pattern for legacy system replacement
