# SonarQube Quality Gate Specialist Skill

> **Category:** Tech Skills > QA > SonarQube

## Overview

Configures SonarQube quality gates with proper conditions for code quality enforcement in CI/CD pipelines

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [sonarqube-quality-gate-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
sonarqube-quality-gate-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@sonarqube-quality-gate-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Define quality gate conditions on new code
- Configure conditions: coverage, duplications, issues
- Integrate quality gate with CI/CD pipelines
- Manage different gates for different project types

## Technology Standards Applied

- **Quality Gates**: Gate conditions and threshold configuration
- **New Code Period**: New code definition and analysis
- **CI/CD Integration**: Quality gate feedback in pipelines