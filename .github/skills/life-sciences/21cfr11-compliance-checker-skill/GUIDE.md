# 21 CFR Part 11 Compliance Checker Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when performing comprehensive 21 CFR Part 11 compliance checks for pharmaceutical and biotech computer systems including electronic records requirements, electronic signature controls, and audit trail validation.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [21cfr11-compliance-checker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
21cfr11-compliance-checker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@21cfr11-compliance-checker` agent from the Independent Agents catalogue.

## Key Capabilities

- Evaluate closed system controls: access control, audit trail, device checks
- Assess open system controls: encryption, digital signatures, additional protections
- Validate electronic signature controls per Part 11 Subpart C requirements
- Check signature manifestation, linking, and non-repudiation capabilities

## Industry Standards Applied

- **21 CFR Part 11**: Electronic records and electronic signatures regulatory requirements
- **FDA Part 11 Guidance (2003)**: FDA scope and application guidance for Part 11 enforcement
- **GAMP 5**: Risk-based approach for Part 11 compliant computer systems