# K8s Helm Chart Developer Skill

> **Category:** Tech Skills > DevOps > Kubernetes

## Overview

Creates and manages Helm charts for Kubernetes application packaging with templating, dependencies, and chart testing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [k8s-helm-chart-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
k8s-helm-chart-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@k8s-helm-chart-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Create Helm charts with proper template structure
- Implement values.yaml with sensible defaults
- Manage chart dependencies with requirements
- Create chart tests for validation

## Technology Standards Applied

- **Helm Best Practices**: Chart development guidelines and conventions
- **Chart Templates**: Go template patterns for Helm charts
- **Chart Repository**: Chart publishing and distribution