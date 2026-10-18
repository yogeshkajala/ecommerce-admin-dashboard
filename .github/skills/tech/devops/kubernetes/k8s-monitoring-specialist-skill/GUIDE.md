# K8s Monitoring Specialist Skill

> **Category:** Tech Skills > DevOps > Kubernetes

## Overview

Implements Kubernetes monitoring with Prometheus, Grafana, and metrics-server for cluster and application observability

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [k8s-monitoring-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
k8s-monitoring-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@k8s-monitoring-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Deploy Prometheus with kube-prometheus-stack
- Configure ServiceMonitors for application metrics
- Build Grafana dashboards for cluster visibility
- Set up AlertManager with proper routing

## Technology Standards Applied

- **Prometheus**: Metric collection and alerting patterns
- **Grafana**: Dashboard design and visualization
- **kube-prometheus**: Production monitoring stack for Kubernetes