# Defect Fixer Skill

> **Category:** Generic Skills

## Overview

Use when performing root cause analysis (5 Whys, fault tree), implementing minimal-impact fixes, assessing fix blast radius, or preparing hotfix patches for defects.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [defect-fixer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
defect-fixer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@defect-fixer` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze complex systems and decompose into manageable components
- Design solutions following established patterns and conventions
- Generate structured artifacts with consistent formatting and quality
- Validate outputs against acceptance criteria and quality gates

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
