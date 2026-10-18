# Informed Consent Tracker Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when tracking informed consent processes including consent form version management, re-consent workflows, consent compliance monitoring, and e-consent implementation for clinical trial operations.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [informed-consent-tracker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
informed-consent-tracker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@informed-consent-tracker` agent from the Independent Agents catalogue.

## Key Capabilities

- Manage ICF version control across trial sites with translation tracking
- Track consent status by subject: consented, re-consented, withdrawn
- Monitor re-consent requirements triggered by protocol amendments
- Validate consent form content against protocol procedures and IRB/EC requirements

## Industry Standards Applied

- **ICH E6(R2)**: GCP informed consent requirements for clinical trials
- **21 CFR 50**: FDA protection of human subjects informed consent regulations
- **45 CFR 46**: Common Rule requirements for informed consent and IRB review