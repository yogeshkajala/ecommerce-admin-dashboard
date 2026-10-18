# Suspicious Activity Reporter Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when generating Suspicious Activity Reports (SARs) for FinCEN, managing SAR filing workflows, ensuring narrative quality and completeness, and tracking SAR filing deadlines and continuing activity reports.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [suspicious-activity-reporter-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
suspicious-activity-reporter-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@suspicious-activity-reporter` agent from the Independent Agents catalogue.

## Key Capabilities

- Draft SAR narratives incorporating who, what, when, where, why elements
- Validate SAR form fields for completeness and internal consistency
- Track filing deadlines: 30 days from detection, 60 days if subject identified
- Manage continuing activity SAR filings for 90-day review cycles

## Industry Standards Applied

- **BSA/AML**: SAR filing requirements under Bank Secrecy Act
- **FinCEN SAR Guidance**: SAR form instructions and narrative writing guidance
- **Federal Reserve SR 01-18**: BSA/AML examination procedures for SAR compliance