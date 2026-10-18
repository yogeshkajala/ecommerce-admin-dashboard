# Ansible Vault Manager Skill

> **Category:** Tech Skills > DevOps > Ansible

## Overview

Manages secrets and sensitive data with Ansible Vault including encryption, key rotation, and integration with external secret stores

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [ansible-vault-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
ansible-vault-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@ansible-vault-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Encrypt files and strings with ansible-vault
- Integrate with HashiCorp Vault for dynamic secrets
- Configure multiple vault IDs for different environments
- Implement key rotation procedures

## Technology Standards Applied

- **Ansible Vault**: Built-in encryption for sensitive data
- **Secret Management**: External secret store integration patterns
- **Key Rotation**: Vault password rotation procedures