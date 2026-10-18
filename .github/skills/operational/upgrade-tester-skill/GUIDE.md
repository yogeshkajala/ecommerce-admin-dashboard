# Upgrade Tester Skill

> **Category:** Domain Skills

## Overview

Use when testing upgrades -- compatibility testing, regression testing, performance comparison, and rollback verification.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [upgrade-tester-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
upgrade-tester-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@upgrade-tester` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness

## Industry Standards Applied

- **ISTQB Foundation**: Test design techniques, test levels, and test process framework
- **ISO 25010**: Software quality model: functional suitability, reliability, usability
- **OWASP Testing Guide**: Security testing methodology for web applications
