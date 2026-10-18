# Exception Manager Skill

> **Category:** Domain Skills

## Overview

Use when managing policy exceptions, granting temporary waivers, tracking exception lifecycle, revoking expired exceptions, or auditing exception usage.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [exception-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
exception-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@exception-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Evaluate compliance posture against regulatory frameworks (SOC2, GDPR, HIPAA, PCI-DSS)
- Assess control effectiveness through evidence collection and gap analysis
- Detect policy violations and configuration drift from security baselines
- Generate audit findings with severity classification and remediation guidance

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
