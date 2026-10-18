# Go Performance Optimizer Skill

> **Category:** Tech Skills > Backend > Go

## Overview

Profiles and optimizes Go application performance through pprof analysis, memory allocation reduction, and runtime tuning

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [go-performance-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
go-performance-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@go-performance-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Profile CPU and memory with pprof
- Write benchmarks with testing.B
- Reduce allocations with sync.Pool and buffer reuse
- Optimize with escape analysis awareness

## Technology Standards Applied

- **pprof**: Go profiling tool for CPU and memory analysis
- **Benchmarks**: Writing and interpreting Go benchmarks
- **GC Tuning**: GOGC and memory limit configuration