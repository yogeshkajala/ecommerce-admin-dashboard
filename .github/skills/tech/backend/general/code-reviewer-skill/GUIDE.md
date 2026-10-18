# Code Reviewer Skill

> **Category:** Tech Skills

## Overview

Use when reviewing code for correctness, security vulnerabilities (OWASP Top 10), performance anti-patterns, and coding standards compliance.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [code-reviewer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
code-reviewer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@code-reviewer` agent from the Independent Agents catalogue.

## Key Capabilities

- Generate production-quality code following language-specific best practices
- Apply SOLID principles and established design patterns appropriately
- Implement proper error handling, input validation, and logging
- Create interfaces, adapters, and abstractions for clean architecture boundaries

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
