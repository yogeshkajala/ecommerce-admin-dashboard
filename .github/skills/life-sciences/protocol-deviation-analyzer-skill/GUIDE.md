# Protocol Deviation Analyzer Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when analyzing clinical trial protocol deviations including deviation classification, trend analysis, root cause patterns, impact assessment on data integrity, and corrective action tracking for GCP compliance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [protocol-deviation-analyzer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
protocol-deviation-analyzer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@protocol-deviation-analyzer` agent from the Independent Agents catalogue.

## Key Capabilities

- Classify deviations by type: inclusion/exclusion, visit window, procedure, consent, safety reporting
- Assess deviation severity: critical, major, minor per impact on data and safety
- Trend deviations by site, type, and time period for pattern identification
- Analyze root causes using 5-why and pattern recognition across similar deviations

## Industry Standards Applied

- **ICH E6(R2)**: GCP protocol deviation handling and reporting requirements
- **21 CFR 312.66**: FDA requirements for reporting protocol deviations in IND studies
- **FDA Guidance on Protocol Deviations**: FDA approach to evaluation of protocol deviations in clinical trials