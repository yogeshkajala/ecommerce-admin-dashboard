# Safety Database Reconciler Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when reconciling safety databases including ICSR reconciliation between sponsors and partners, global safety database integrity validation, duplicate case detection, and regulatory compliance for pharmacovigilance data management.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [safety-database-reconciler-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
safety-database-reconciler-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@safety-database-reconciler` agent from the Independent Agents catalogue.

## Key Capabilities

- Reconcile ICSRs between safety databases: sponsor, partner, CRO, regulatory
- Detect duplicate cases using patient, event, and reporter matching algorithms
- Validate data integrity: mandatory fields, coding accuracy, causality consistency
- Track reconciliation status with exception management and resolution

## Industry Standards Applied

- **ICH E2B(R3)**: ICSR data elements for reconciliation and data exchange
- **EU GVP Module VI**: Collection, management, and submission of ICSR reports
- **FDA Safety Reporting**: Post-marketing safety reporting and database requirements