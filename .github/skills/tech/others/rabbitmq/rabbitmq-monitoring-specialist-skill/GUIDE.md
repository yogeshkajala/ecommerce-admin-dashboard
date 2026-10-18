# RabbitMQ Monitoring Specialist Skill

> **Category:** Tech Skills > Others > RabbitMQ

## Overview

Implements RabbitMQ monitoring with Prometheus, Grafana, and management plugin for queue depth, consumer lag, and cluster health visibility

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [rabbitmq-monitoring-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
rabbitmq-monitoring-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@rabbitmq-monitoring-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure Prometheus plugin for metric export
- Build Grafana dashboards for RabbitMQ metrics
- Monitor queue depth and consumer lag
- Alert on cluster health issues

## Technology Standards Applied

- **Prometheus Plugin**: RabbitMQ Prometheus metric export
- **Grafana**: Dashboard design for RabbitMQ
- **Alerting**: Queue and cluster alert patterns