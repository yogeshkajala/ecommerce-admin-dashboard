# User Feedback Collector Skill

> **Category:** Domain Skills

## Overview

Use when collecting and analyzing user feedback after upgrades to detect user-impacting issues not visible in technical metrics.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [user-feedback-collector-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
user-feedback-collector-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@user-feedback-collector` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
