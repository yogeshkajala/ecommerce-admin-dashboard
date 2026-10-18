# Compliance Validator Skill

> **Category:** Domain Skills

## Overview

Use when verifying migrated workloads meet regulatory and compliance requirements including data residency, audit logging, and retention policies.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [compliance-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
compliance-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@compliance-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Evaluate compliance posture against regulatory frameworks (SOC2, GDPR, HIPAA, PCI-DSS)
- Assess control effectiveness through evidence collection and gap analysis
- Detect policy violations and configuration drift from security baselines
- Generate audit findings with severity classification and remediation guidance

## Industry Standards Applied

- **SOC 2 Type II**: Trust service criteria: security, availability, processing integrity
- **ISO 27001**: Information security management system (ISMS) controls
- **GDPR/CCPA**: Data privacy and protection regulatory requirements
