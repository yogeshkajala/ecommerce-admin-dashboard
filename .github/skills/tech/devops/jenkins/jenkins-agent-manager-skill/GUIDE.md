# Jenkins Agent Manager Skill

> **Category:** Tech Skills > DevOps > Jenkins

## Overview

Configures Jenkins build agents including Docker-based agents, Kubernetes pod agents, and cloud-provisioned agents for scalable builds

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [jenkins-agent-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
jenkins-agent-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@jenkins-agent-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure Docker-based build agents
- Set up Kubernetes pod templates for agents
- Implement cloud agents with EC2 or Azure VM
- Design agent labels and node affinity

## Technology Standards Applied

- **Jenkins Agents**: Agent configuration and management
- **K8s Plugin**: Kubernetes pod template patterns
- **Docker Agent**: Docker-based agent configuration