# Modernization Validator Skill

> **Category:** Domain Skills

## Overview

Use when validating modernized applications for cloud-native compliance, scalability, resilience, and cost efficiency.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [modernization-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
modernization-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@modernization-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Evaluate compliance posture against regulatory frameworks (SOC2, GDPR, HIPAA, PCI-DSS)
- Assess control effectiveness through evidence collection and gap analysis
- Detect policy violations and configuration drift from security baselines
- Generate audit findings with severity classification and remediation guidance

## Industry Standards Applied

- **AWS 7R Migration**: Migration strategies: rehost, replatform, refactor, repurchase, retire, retain, relocate
- **TOGAF ADM**: Architecture development method for transformation initiatives
- **Strangler Fig Pattern**: Incremental migration pattern for legacy system replacement
