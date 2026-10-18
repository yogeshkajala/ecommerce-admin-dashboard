# Ansible Playbook Developer Skill

> **Category:** Tech Skills > DevOps > Ansible

## Overview

Creates Ansible playbooks for infrastructure automation with proper task design, error handling, and idempotent operations

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [ansible-playbook-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
ansible-playbook-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@ansible-playbook-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Write idempotent playbooks with proper task design
- Implement handlers for service management
- Use variables, facts, and templates for flexibility
- Configure error handling with blocks and rescue

## Technology Standards Applied

- **Ansible Best Practices**: Playbook organization and task design
- **Idempotency**: Ensuring repeated runs produce same results
- **ansible-lint**: Playbook quality and style checking