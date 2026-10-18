# Docker Multi-Stage Builder Skill

> **Category:** Tech Skills > DevOps > Docker

## Overview

Designs advanced multi-stage Docker builds for compiled languages with build caching, dependency management, and minimal runtime images

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [docker-multi-stage-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
docker-multi-stage-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@docker-multi-stage-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Design multi-stage builds for Go, Java, Rust, .NET
- Implement BuildKit cache mounts for dependencies
- Create distroless or scratch-based runtime images
- Optimize build stages for parallelism

## Technology Standards Applied

- **Multi-Stage Builds**: Build optimization with multiple stages
- **BuildKit**: Advanced build features and caching
- **Distroless**: Minimal runtime images without shell