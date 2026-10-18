# AWS CloudFormation Developer Skill

> **Category:** Tech Skills > DevOps > AWS

## Overview

Creates AWS CloudFormation templates for infrastructure as code with proper resource design, parameters, and stack management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [aws-cloudformation-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
aws-cloudformation-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@aws-cloudformation-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Create CloudFormation templates with proper resources
- Implement nested stacks for modular design
- Use parameters and mappings for flexibility
- Configure outputs and cross-stack references

## Technology Standards Applied

- **CloudFormation**: Template syntax and resource specification
- **Nested Stacks**: Modular template composition
- **Change Sets**: Safe deployment with change preview