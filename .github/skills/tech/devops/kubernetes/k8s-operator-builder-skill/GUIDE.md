# K8s Operator Builder Skill

> **Category:** Tech Skills > DevOps > Kubernetes

## Overview

Builds Kubernetes operators with Operator SDK or kubebuilder for custom resource management and automated operations

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [k8s-operator-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
k8s-operator-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@k8s-operator-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Build operators with kubebuilder or Operator SDK
- Define CRDs with proper validation schemas
- Implement reconciliation loops with proper error handling
- Handle finalizers for cleanup operations

## Technology Standards Applied

- **Operator Pattern**: Kubernetes operator design patterns
- **kubebuilder**: Operator development framework
- **CRD Design**: Custom Resource Definition best practices