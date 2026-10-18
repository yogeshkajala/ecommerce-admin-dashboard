# Modernization Deployer Skill

> **Category:** Domain Skills

## Overview

Use when deploying modernized applications including infrastructure provisioning, service mesh configuration, CI/CD pipeline setup, and feature flag management.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [modernization-deployer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
modernization-deployer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@modernization-deployer` agent from the Independent Agents catalogue.

## Key Capabilities

- Assess source systems for migration readiness and complexity
- Classify migration strategy using 7R framework
- Plan migration waves with dependency ordering and cutover scheduling
- Execute data migration with integrity verification and rollback readiness

## Industry Standards Applied

- **Well-Architected Framework**: Cloud architecture pillars: security, reliability, performance, cost, operations
- **12-Factor App**: Methodology for building cloud-native, scalable services
- **CIS Benchmarks**: Security configuration baselines for cloud platforms
