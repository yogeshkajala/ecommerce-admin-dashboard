# GitHub Actions Artifact Manager Skill

> **Category:** Tech Skills > DevOps > GitHub Actions

## Overview

Manages build artifacts in GitHub Actions workflows including upload/download, caching strategies, and artifact retention policies

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [gha-artifact-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
gha-artifact-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@gha-artifact-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Upload and download artifacts between jobs
- Configure dependency caching with actions/cache
- Implement custom cache keys for invalidation
- Set retention policies for artifact cleanup

## Technology Standards Applied

- **Artifacts**: actions/upload-artifact and download-artifact
- **Caching**: Dependency caching patterns and key design
- **Retention**: Artifact and log retention configuration