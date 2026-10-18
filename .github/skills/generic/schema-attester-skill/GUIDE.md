# Schema Attester Skill

> **Category:** Domain Skills

## Overview

Use when validating structured AI outputs against JSON schemas, enforcing data contracts, detecting fabricated fields or values, or ensuring output format compliance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [schema-attester-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
schema-attester-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@schema-attester` agent from the Independent Agents catalogue.

## Key Capabilities

- Evaluate compliance posture against regulatory frameworks (SOC2, GDPR, HIPAA, PCI-DSS)
- Assess control effectiveness through evidence collection and gap analysis
- Detect policy violations and configuration drift from security baselines
- Generate audit findings with severity classification and remediation guidance

## Industry Standards Applied

- **ISTQB Foundation**: Test design techniques, test levels, and test process framework
- **ISO 25010**: Software quality model: functional suitability, reliability, usability
- **OWASP Testing Guide**: Security testing methodology for web applications
