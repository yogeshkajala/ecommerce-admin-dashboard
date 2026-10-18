# Drug Safety Signal Detector Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when detecting drug safety signals from adverse event databases including disproportionality analysis, signal evaluation, benefit-risk assessment, and regulatory safety reporting for pharmacovigilance operations.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [drug-safety-signal-detector-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
drug-safety-signal-detector-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@drug-safety-signal-detector` agent from the Independent Agents catalogue.

## Key Capabilities

- Execute disproportionality analysis: PRR, ROR, EBGM, IC using FAERS/EudraVigilance data
- Detect new safety signals from spontaneous reporting and clinical trial safety data
- Evaluate signal strength using clinical, statistical, and epidemiological criteria
- Perform cumulative case review for confirmed signals with narrative assessment

## Industry Standards Applied

- **ICH E2E**: Pharmacovigilance planning for drug safety signal detection
- **FDA Guidance on Safety Reporting**: Post-marketing safety reporting requirements and signal management
- **EU GVP Module IX**: Signal management process requirements for pharmacovigilance