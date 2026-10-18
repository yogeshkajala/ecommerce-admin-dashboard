# Code Analysis Engine Skill

> **Category:** Tech Skills

## Overview

Use when performing comprehensive codebase analysis including architecture mapping, security scanning (OWASP Top 10), dependency audits (SBOM/CVE), tech debt assessment, or generating repository health reports.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [code-analysis-engine-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
code-analysis-engine-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@code-analysis-engine` agent from the Independent Agents catalogue.

## Key Capabilities

- Generate production-quality code following language-specific best practices
- Apply SOLID principles and established design patterns appropriately
- Implement proper error handling, input validation, and logging
- Create interfaces, adapters, and abstractions for clean architecture boundaries

## Industry Standards Applied

- **IEEE 730**: Software quality assurance processes and standards
- **ISO 25010**: Software quality model: functional suitability, reliability, maintainability
