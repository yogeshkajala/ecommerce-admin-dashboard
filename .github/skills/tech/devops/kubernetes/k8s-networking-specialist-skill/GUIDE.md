# K8s Networking Specialist Skill

> **Category:** Tech Skills > DevOps > Kubernetes

## Overview

Configures Kubernetes networking with Services, Ingress, Network Policies, and service mesh for secure communication

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [k8s-networking-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
k8s-networking-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@k8s-networking-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure ClusterIP, NodePort, and LoadBalancer Services
- Implement Ingress with TLS termination
- Create Network Policies for pod-level isolation
- Configure service mesh with Istio or Linkerd

## Technology Standards Applied

- **K8s Networking**: Service and Ingress configuration patterns
- **Network Policies**: Pod-level network isolation
- **Service Mesh**: Istio/Linkerd traffic management and security