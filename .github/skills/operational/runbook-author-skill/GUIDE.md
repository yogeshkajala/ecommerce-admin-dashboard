# Runbook Author Skill

> **Category:** Domain Skills

## Overview

Use when authoring operational runbooks for failure modes, alerts, and incident response procedures.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [runbook-author-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
runbook-author-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@runbook-author` agent from the Independent Agents catalogue.

## Key Capabilities

- Classify incidents by severity using impact, urgency, and blast radius assessment
- Execute structured triage with symptom analysis and correlation
- Perform root cause analysis through 5-Why, fishbone, and fault tree methods
- Execute containment and remediation actions with safety guardrails

## Industry Standards Applied

- **ITIL v4**: IT service management: incident, problem, change management
- **SRE Principles (Google)**: SLO/SLI, error budgets, toil reduction, blameless postmortems
- **ISO 20000**: IT service management system requirements
