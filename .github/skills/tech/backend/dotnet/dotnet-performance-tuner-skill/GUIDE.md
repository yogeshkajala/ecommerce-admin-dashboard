# .NET Performance Tuner Skill

> **Category:** Tech Skills > Backend > .NET

## Overview

Profiles and optimizes .NET application performance through memory analysis, async optimization, and runtime configuration tuning

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [dotnet-performance-tuner-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
dotnet-performance-tuner-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@dotnet-performance-tuner` agent from the Independent Agents catalogue.

## Key Capabilities

- Profile applications with dotnet-trace and dotnet-counters
- Analyze memory with dotnet-dump and PerfView
- Optimize async/await for reduced allocations
- Configure thread pool and GC for workload type

## Technology Standards Applied

- **BenchmarkDotNet**: Microbenchmark framework for .NET
- **.NET Performance**: Official performance best practices
- **GC Tuning**: Garbage collection configuration guidelines