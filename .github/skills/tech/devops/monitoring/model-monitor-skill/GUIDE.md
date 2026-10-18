# Model Monitor Skill

> **Category:** Tech Skills

## Overview

Use when monitoring production model performance, detecting data drift, concept drift, or evaluating prediction quality degradation.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [model-monitor-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
model-monitor-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@model-monitor` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure telemetry collection across metrics, logs, and distributed traces
- Establish baseline metrics and detect anomalies using statistical analysis
- Correlate signals across multiple data sources for root cause identification
- Define and tune alert rules with severity thresholds and noise reduction

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
