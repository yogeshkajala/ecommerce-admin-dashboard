# K8s Autoscaling Specialist Skill

> **Category:** Tech Skills > DevOps > Kubernetes

## Overview

Configures Kubernetes autoscaling with HPA, VPA, and cluster autoscaler for dynamic resource management based on demand

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [k8s-autoscaling-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
k8s-autoscaling-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@k8s-autoscaling-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure HPA with CPU, memory, and custom metrics
- Set up VPA for automatic resource right-sizing
- Implement cluster autoscaler for node scaling
- Configure KEDA for event-driven autoscaling

## Technology Standards Applied

- **HPA**: Horizontal Pod Autoscaler configuration
- **VPA**: Vertical Pod Autoscaler for resource tuning
- **KEDA**: Event-driven autoscaling patterns