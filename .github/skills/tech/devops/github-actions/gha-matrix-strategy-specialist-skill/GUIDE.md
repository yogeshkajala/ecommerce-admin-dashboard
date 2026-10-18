# GitHub Actions Matrix Strategy Specialist Skill

> **Category:** Tech Skills > DevOps > GitHub Actions

## Overview

Designs complex matrix strategies for GitHub Actions to test across multiple platforms, versions, and configurations efficiently

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [gha-matrix-strategy-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
gha-matrix-strategy-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@gha-matrix-strategy-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Design matrix strategies with multiple dimensions
- Configure exclusions and dynamic includes
- Implement fail-fast and max-parallel settings
- Use matrix outputs for downstream jobs

## Technology Standards Applied

- **Matrix Strategy**: GitHub Actions matrix configuration
- **Dynamic Matrix**: Generating matrices from job outputs
- **Concurrency**: Managing parallel job execution