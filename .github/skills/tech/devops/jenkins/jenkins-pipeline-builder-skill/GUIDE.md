# Jenkins Pipeline Builder Skill

> **Category:** Tech Skills > DevOps > Jenkins

## Overview

Creates Jenkins declarative and scripted pipelines for CI/CD automation with stages, parallel execution, and artifact management

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [jenkins-pipeline-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
jenkins-pipeline-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@jenkins-pipeline-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Build declarative pipelines with proper stage design
- Implement parallel stages for faster execution
- Configure post actions for notifications and cleanup
- Use pipeline steps for common CI/CD tasks

## Technology Standards Applied

- **Jenkins Pipeline**: Declarative pipeline syntax and patterns
- **Parallel Stages**: Concurrent execution for speed
- **Post Actions**: Cleanup and notification patterns