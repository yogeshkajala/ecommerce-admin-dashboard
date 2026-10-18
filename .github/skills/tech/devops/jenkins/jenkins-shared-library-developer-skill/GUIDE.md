# Jenkins Shared Library Developer Skill

> **Category:** Tech Skills > DevOps > Jenkins

## Overview

Creates Jenkins shared libraries for reusable pipeline code with custom steps, global variables, and proper testing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [jenkins-shared-library-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
jenkins-shared-library-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@jenkins-shared-library-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Create shared libraries with proper structure
- Implement custom pipeline steps as vars
- Build class-based shared library code in src
- Test library code with JenkinsPipelineUnit

## Technology Standards Applied

- **Shared Libraries**: Library structure and loading patterns
- **Custom Steps**: Pipeline step development conventions
- **Testing**: JenkinsPipelineUnit testing patterns