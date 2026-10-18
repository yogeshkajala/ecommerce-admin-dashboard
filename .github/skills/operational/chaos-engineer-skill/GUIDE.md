# Chaos Engineer Skill

> **Category:** Tech Skills

## Overview

Execute chaos experiments: pod kill, network partition, latency injection.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [chaos-engineer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
chaos-engineer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@chaos-engineer` agent from the Independent Agents catalogue.

## Key Capabilities

- Provision and configure cloud infrastructure across AWS, Azure, and GCP
- Validate infrastructure-as-code templates for security and compliance
- Execute capacity planning based on workload patterns and growth projections
- Configure auto-scaling policies with appropriate thresholds and cooldowns

## Industry Standards Applied

- **ITIL v4**: IT service management: incident, problem, change management
- **SRE Principles (Google)**: SLO/SLI, error budgets, toil reduction, blameless postmortems
- **ISO 20000**: IT service management system requirements
