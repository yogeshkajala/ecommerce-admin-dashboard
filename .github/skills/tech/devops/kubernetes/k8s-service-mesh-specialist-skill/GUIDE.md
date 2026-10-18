# K8s Service Mesh Specialist Skill

> **Category:** Tech Skills > DevOps > Kubernetes

## Overview

Implements service mesh with Istio or Linkerd for traffic management, mTLS, observability, and resilience in Kubernetes

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [k8s-service-mesh-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
k8s-service-mesh-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@k8s-service-mesh-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Deploy Istio or Linkerd service mesh
- Configure mTLS for zero-trust networking
- Implement traffic management with VirtualService and DestinationRule
- Set up distributed tracing with Jaeger

## Technology Standards Applied

- **Istio**: Istio configuration and traffic management
- **Linkerd**: Lightweight service mesh patterns
- **mTLS**: Mutual TLS for service-to-service encryption