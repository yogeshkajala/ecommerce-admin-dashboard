# Metric Comparator Skill

> **Category:** Tech Skills

## Overview

Use when comparing operational metrics between pre-upgrade baseline and post-upgrade live measurements.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [metric-comparator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
metric-comparator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@metric-comparator` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure telemetry collection across metrics, logs, and distributed traces
- Establish baseline metrics and detect anomalies using statistical analysis
- Correlate signals across multiple data sources for root cause identification
- Define and tune alert rules with severity thresholds and noise reduction

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
