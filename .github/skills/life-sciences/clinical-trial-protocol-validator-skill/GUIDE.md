# Clinical Trial Protocol Validator Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when validating clinical trial protocol design including endpoint selection, statistical analysis plan adequacy, ICH E6(R2) GCP compliance, inclusion/exclusion criteria assessment, and protocol amendment impact analysis.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [clinical-trial-protocol-validator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
clinical-trial-protocol-validator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@clinical-trial-protocol-validator` agent from the Independent Agents catalogue.

## Key Capabilities

- Validate protocol structure against ICH E6(R2) GCP requirements
- Assess primary and secondary endpoint selection for clinical and regulatory relevance
- Evaluate statistical analysis plan: sample size, power, analysis populations, missing data handling
- Check inclusion/exclusion criteria for scientific rationale and operational feasibility

## Industry Standards Applied

- **ICH E6(R2)**: Good Clinical Practice guidelines for clinical trial conduct
- **ICH E8(R1)**: General considerations for clinical studies design framework
- **ICH E9(R1)**: Statistical principles for clinical trials including estimands