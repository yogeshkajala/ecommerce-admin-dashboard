# Go Concurrency Specialist Skill

> **Category:** Tech Skills > Backend > Go

## Overview

Implements concurrent Go applications using goroutines, channels, select statements, and sync primitives for safe parallel execution

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [go-concurrency-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
go-concurrency-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@go-concurrency-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Design goroutine patterns with proper lifecycle management
- Implement channel-based communication patterns
- Use sync.WaitGroup, Mutex, and atomic operations
- Build fan-out/fan-in and pipeline patterns

## Technology Standards Applied

- **Go Concurrency Patterns**: Official goroutine and channel patterns
- **Race Detector**: Built-in race condition detection tool
- **Context Package**: Cancellation and timeout propagation