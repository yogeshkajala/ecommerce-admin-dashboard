# Ansible Role Builder Skill

> **Category:** Tech Skills > DevOps > Ansible

## Overview

Creates reusable Ansible roles with proper directory structure, defaults, handlers, and molecule testing for infrastructure automation

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [ansible-role-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
ansible-role-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@ansible-role-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Create roles with standard directory structure
- Define defaults and variables with proper precedence
- Implement handlers for service lifecycle
- Write molecule tests for role validation

## Technology Standards Applied

- **Ansible Roles**: Role structure and organization standards
- **Galaxy**: Role sharing and distribution
- **Molecule**: Role testing framework