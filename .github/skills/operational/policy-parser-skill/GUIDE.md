# Policy Parser Skill

> **Category:** Domain Skills

## Overview

Use when parsing policy definitions from OPA/Rego, JSON Schema, or YAML rule files, validating policy syntax, resolving policy dependencies, or compiling policies for evaluation.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [policy-parser-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
policy-parser-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@policy-parser` agent from the Independent Agents catalogue.

## Key Capabilities

- Evaluate compliance posture against regulatory frameworks (SOC2, GDPR, HIPAA, PCI-DSS)
- Assess control effectiveness through evidence collection and gap analysis
- Detect policy violations and configuration drift from security baselines
- Generate audit findings with severity classification and remediation guidance

## Industry Standards Applied

- **SOC 2 Type II**: Trust service criteria: security, availability, processing integrity
- **ISO 27001**: Information security management system (ISMS) controls
- **GDPR/CCPA**: Data privacy and protection regulatory requirements
