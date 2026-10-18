# Azure AKS Specialist Skill

> **Category:** Tech Skills > DevOps > Azure

## Overview

Deploys and manages Azure Kubernetes Service clusters with proper node pool design, networking, and integration with Azure services

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [azure-aks-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
azure-aks-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@azure-aks-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Deploy AKS clusters with proper node pool design
- Configure Azure CNI for networking
- Integrate with Azure AD for RBAC
- Set up Key Vault for secret management

## Technology Standards Applied

- **AKS Best Practices**: Cluster configuration and security guidelines
- **Azure CNI**: Networking options for AKS
- **Managed Identity**: Identity integration for AKS workloads