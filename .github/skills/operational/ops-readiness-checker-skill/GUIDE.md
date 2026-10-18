# Ops Readiness Checker Skill

> **Category:** Domain Skills

## Overview

Use when verifying operational readiness -- monitoring, alerting, runbooks, and capacity -- before modernized services go live.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [ops-readiness-checker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
ops-readiness-checker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@ops-readiness-checker` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
