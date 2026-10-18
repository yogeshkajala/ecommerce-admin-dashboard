# Postman Environment Manager Skill

> **Category:** Tech Skills > QA > Postman

## Overview

Manages Postman environments with proper variable scoping, secret handling, and environment switching for multi-stage API testing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [postman-environment-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
postman-environment-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@postman-environment-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Create environments for dev, staging, production
- Configure variable scoping and precedence
- Handle secrets with proper masking
- Implement dynamic environment variables

## Technology Standards Applied

- **Environments**: Environment variable management
- **Variable Scoping**: Variable precedence and overrides
- **Secrets**: Sensitive data handling in environments