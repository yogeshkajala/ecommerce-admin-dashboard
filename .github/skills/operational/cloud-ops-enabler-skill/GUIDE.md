# Cloud Ops Enabler Skill

> **Category:** Domain Skills

## Overview

Use when enabling cloud operations for modernized applications including observability, auto-scaling, backup strategies, and incident playbooks.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [cloud-ops-enabler-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
cloud-ops-enabler-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@cloud-ops-enabler` agent from the Independent Agents catalogue.

## Key Capabilities

- Classify incidents by severity using impact, urgency, and blast radius assessment
- Execute structured triage with symptom analysis and correlation
- Perform root cause analysis through 5-Why, fishbone, and fault tree methods
- Execute containment and remediation actions with safety guardrails

## Industry Standards Applied

- **Well-Architected Framework**: Cloud architecture pillars: security, reliability, performance, cost, operations
- **12-Factor App**: Methodology for building cloud-native, scalable services
- **CIS Benchmarks**: Security configuration baselines for cloud platforms
