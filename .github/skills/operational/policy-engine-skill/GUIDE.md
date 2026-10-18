# Policy Engine Skill

> **Category:** Domain Skills

## Overview

Use when enforcing governance policies as code, evaluating compliance, checking resources against policy rules, managing policy exceptions, or generating compliance reports.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [policy-engine-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
policy-engine-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@policy-engine` agent from the Independent Agents catalogue.

## Key Capabilities

- Evaluate compliance posture against regulatory frameworks (SOC2, GDPR, HIPAA, PCI-DSS)
- Assess control effectiveness through evidence collection and gap analysis
- Detect policy violations and configuration drift from security baselines
- Generate audit findings with severity classification and remediation guidance

## Industry Standards Applied

- **SOC 2 Type II**: Trust service criteria: security, availability, processing integrity
- **ISO 27001**: Information security management system (ISMS) controls
- **GDPR/CCPA**: Data privacy and protection regulatory requirements
