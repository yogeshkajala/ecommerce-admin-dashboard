# CAPA Workflow Manager Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when managing Corrective and Preventive Action (CAPA) workflows in pharmaceutical quality systems including root cause analysis, action plan development, implementation tracking, and effectiveness verification.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [capa-workflow-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
capa-workflow-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@capa-workflow-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Initiate CAPA from multiple quality event sources with proper linkage
- Facilitate root cause analysis using 5-Why, fishbone, and fault tree methodologies
- Develop action plans distinguishing corrective (address cause) from preventive (prevent recurrence)
- Assign CAPA actions with responsible parties, target dates, and success criteria

## Industry Standards Applied

- **21 CFR 820.90**: FDA QSR corrective and preventive action requirements for medical devices
- **ICH Q10**: Pharmaceutical Quality System CAPA framework
- **ISO 13485**: Medical devices quality management CAPA requirements