# Legacy Deployment Manager Skill

> **Category:** Domain Skills

## Overview

Use when managing legacy migration deployment including cutover planning, parallel run coordination, data synchronization, and fallback procedures.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [legacy-deployment-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
legacy-deployment-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@legacy-deployment-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness

## Industry Standards Applied

- **Well-Architected Framework**: Cloud architecture pillars: security, reliability, performance, cost, operations
- **12-Factor App**: Methodology for building cloud-native, scalable services
- **CIS Benchmarks**: Security configuration baselines for cloud platforms
