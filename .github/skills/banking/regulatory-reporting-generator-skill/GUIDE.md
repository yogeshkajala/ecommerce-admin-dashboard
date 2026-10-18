# Regulatory Reporting Generator Skill

> **Category:** Domain Skills > Industry > Banking

## Overview

Use when generating regulatory reports for banking supervisors including Call Reports (FFIEC 031/041), FR Y-9C, CCAR/DFAST stress test submissions, and other prudential reporting requirements.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [regulatory-reporting-generator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
regulatory-reporting-generator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@regulatory-reporting-generator` agent from the Independent Agents catalogue.

## Key Capabilities

- Generate FFIEC 031/041 Call Report schedules from general ledger data
- Produce FR Y-9C consolidated financial statements with inter-company eliminations
- Calculate stress test scenarios for CCAR/DFAST with macroeconomic variable projections
- Validate data lineage from source systems through transformation to report output

## Industry Standards Applied

- **FFIEC 031/041**: Call Report instructions for domestic and foreign office banks
- **FR Y-9C**: Federal Reserve consolidated financial statements for BHCs
- **Basel III**: Capital adequacy calculation methodology and ratios