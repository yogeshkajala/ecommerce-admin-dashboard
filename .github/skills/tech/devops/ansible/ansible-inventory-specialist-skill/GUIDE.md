# Ansible Inventory Specialist Skill

> **Category:** Tech Skills > DevOps > Ansible

## Overview

Designs Ansible inventory management with static and dynamic inventories, groups, and variables for multi-environment infrastructure

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [ansible-inventory-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
ansible-inventory-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@ansible-inventory-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Design static inventories with groups and children
- Implement dynamic inventory from AWS, Azure, GCP
- Configure group and host variables
- Use inventory plugins for custom sources

## Technology Standards Applied

- **Ansible Inventory**: Inventory organization and management
- **Dynamic Inventory**: Cloud provider inventory plugins
- **Variable Precedence**: Understanding variable override order