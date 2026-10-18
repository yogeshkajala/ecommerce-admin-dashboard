# Business Rule Extractor Skill

> **Category:** Domain Skills

## Overview

Use when extracting business rules from legacy code, stored procedures, configuration files, and documentation.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [business-rule-extractor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
business-rule-extractor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@business-rule-extractor` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
