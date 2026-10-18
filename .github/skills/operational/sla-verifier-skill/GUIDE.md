# Sla Verifier Skill

> **Category:** Domain Skills

## Overview

Use when verifying SLA compliance after upgrades -- availability, latency, and error rate targets.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [sla-verifier-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
sla-verifier-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@sla-verifier` agent from the Independent Agents catalogue.

## Key Capabilities

- Evaluate compliance posture against regulatory frameworks (SOC2, GDPR, HIPAA, PCI-DSS)
- Assess control effectiveness through evidence collection and gap analysis
- Detect policy violations and configuration drift from security baselines
- Generate audit findings with severity classification and remediation guidance

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
