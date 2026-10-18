# Clinical Site Performance Monitor Skill

> **Category:** Domain Skills > Industry > Life Sciences

## Overview

Use when monitoring clinical trial site performance including enrollment rates, data quality metrics, protocol compliance, query resolution times, and site risk assessment for clinical operations management.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [clinical-site-performance-monitor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
clinical-site-performance-monitor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@clinical-site-performance-monitor` agent from the Independent Agents catalogue.

## Key Capabilities

- Track site enrollment metrics: screening rate, screen failure rate, randomization rate
- Monitor data quality indicators: query rate, query open time, CRF completion timeliness
- Assess protocol compliance: visit window adherence, procedure completion, consent compliance
- Calculate site risk scores using composite of quality, enrollment, and compliance metrics

## Industry Standards Applied

- **ICH E6(R2)**: GCP requirements for clinical monitoring and site oversight
- **FDA Risk-Based Monitoring Guidance**: FDA guidance on risk-based approach to clinical trial monitoring
- **EMA GCP Inspections**: EU GCP inspection expectations for site oversight