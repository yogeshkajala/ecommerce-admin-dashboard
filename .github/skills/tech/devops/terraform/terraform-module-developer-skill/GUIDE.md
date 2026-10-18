# Terraform Module Developer Skill

> **Category:** Tech Skills > DevOps > Terraform

## Overview

Creates reusable Terraform modules with proper input variables, outputs, and documentation for infrastructure code sharing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [terraform-module-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
terraform-module-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@terraform-module-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Design modules with proper variable definitions
- Implement module composition with nested modules
- Create outputs for inter-module communication
- Write module documentation with terraform-docs

## Technology Standards Applied

- **Module Registry**: Module publishing standards and conventions
- **Module Design**: Input/output and composition patterns
- **terraform-docs**: Automated documentation generation