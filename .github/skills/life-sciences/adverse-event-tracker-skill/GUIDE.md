# Adverse Event Tracker Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when tracking adverse events throughout clinical trial conduct including AE/SAE collection, causality assessment, MedDRA coding, expedited reporting compliance, and safety data trending for clinical operations.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [adverse-event-tracker-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
adverse-event-tracker-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@adverse-event-tracker` agent from the Independent Agents catalogue.

## Key Capabilities

- Track AE/SAE collection across all trial sites with completeness monitoring
- Manage causality assessment workflow: investigator assessment and sponsor override
- Code adverse events using MedDRA: LLT, PT, HLT, HLGT, SOC hierarchy
- Monitor expedited reporting deadlines: 15-day fatal/life-threatening, 15-day unexpected

## Industry Standards Applied

- **ICH E2A**: Clinical safety data management definitions and standards for expedited reporting
- **ICH E2B(R3)**: Individual case safety report electronic transmission requirements
- **MedDRA**: Medical Dictionary for Regulatory Activities coding terminology