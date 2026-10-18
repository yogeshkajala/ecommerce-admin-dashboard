# Real World Evidence Analyzer Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when analyzing real-world evidence (RWE) from electronic health records, claims databases, registries, and other real-world data sources for regulatory submissions, label expansions, and post-marketing safety studies.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [real-world-evidence-analyzer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
real-world-evidence-analyzer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@real-world-evidence-analyzer` agent from the Independent Agents catalogue.

## Key Capabilities

- Design observational study protocols using RWD sources: EHR, claims, registries
- Apply causal inference methods: propensity score matching, IPTW, instrumental variables
- Analyze treatment effectiveness compared to RCT efficacy findings
- Evaluate drug utilization patterns: prescribing trends, adherence, switching

## Industry Standards Applied

- **FDA RWE Framework (2018)**: FDA framework for evaluating real-world evidence in regulatory decisions
- **ICH E2E**: Pharmacovigilance planning using real-world data sources
- **ISPE Guidelines for Good Pharmacoepidemiology Practices**: Standards for pharmacoepidemiological studies using RWD