# Parallel Run Manager Skill

> **Category:** Domain Skills

## Overview

Use when managing parallel runs between legacy and migrated systems including transaction comparison, discrepancy analysis, and confidence scoring.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [parallel-run-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
parallel-run-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@parallel-run-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
