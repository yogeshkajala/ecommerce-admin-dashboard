# Go Module Manager Skill

> **Category:** Tech Skills > Backend > Go

## Overview

Manages Go module dependencies with go.mod, workspace mode, and vendoring for reproducible builds and dependency governance

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [go-module-manager-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
go-module-manager-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@go-module-manager` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure go.mod with proper module paths
- Manage dependency versions with go get and go mod tidy
- Set up Go workspace with go.work for multi-module repos
- Implement vendoring for offline and reproducible builds

## Technology Standards Applied

- **Go Modules**: Official module management documentation
- **Go Workspace**: Multi-module workspace configuration
- **Semver**: Semantic versioning for Go modules