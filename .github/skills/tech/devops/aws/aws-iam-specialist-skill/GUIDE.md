# AWS IAM Specialist Skill

> **Category:** Tech Skills > DevOps > AWS

## Overview

Configures AWS IAM policies, roles, and identity federation for secure access management following least privilege principles

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [aws-iam-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
aws-iam-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@aws-iam-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Create IAM policies with minimal permissions
- Implement cross-account roles with trust policies
- Configure identity federation with external IdP
- Set up permission boundaries for delegation

## Technology Standards Applied

- **IAM Best Practices**: AWS IAM security guidelines
- **Least Privilege**: Minimal permission assignment patterns
- **Access Analyzer**: Unused access and external access detection