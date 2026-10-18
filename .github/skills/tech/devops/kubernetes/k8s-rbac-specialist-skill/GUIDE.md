# K8s RBAC Specialist Skill

> **Category:** Tech Skills > DevOps > Kubernetes

## Overview

Configures Kubernetes RBAC with Roles, ClusterRoles, and ServiceAccounts for least-privilege access control across namespaces

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [k8s-rbac-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
k8s-rbac-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@k8s-rbac-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Design Roles and ClusterRoles with minimal permissions
- Create ServiceAccounts for workload identity
- Implement RoleBindings for namespace-scoped access
- Configure audit logging for RBAC monitoring

## Technology Standards Applied

- **K8s RBAC**: Role-based access control configuration
- **Least Privilege**: Minimal permission assignment patterns
- **Audit Logging**: Kubernetes audit policy configuration