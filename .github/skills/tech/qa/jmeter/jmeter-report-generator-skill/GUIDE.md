# JMeter Report Generator Skill

> **Category:** Tech Skills > QA > JMeter

## Overview

Generates JMeter test reports with HTML dashboard, custom graphs, and trend analysis for performance test result communication

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [jmeter-report-generator-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
jmeter-report-generator-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@jmeter-report-generator` agent from the Independent Agents catalogue.

## Key Capabilities

- Generate HTML dashboard from JTL results
- Configure custom graph generators
- Implement trend analysis across runs
- Export results to InfluxDB for Grafana

## Technology Standards Applied

- **Dashboard Report**: Built-in HTML report generation
- **Grafana**: Real-time and historical dashboards
- **Trend Analysis**: Performance comparison across runs