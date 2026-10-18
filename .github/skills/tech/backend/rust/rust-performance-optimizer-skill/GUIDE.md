# Rust Performance Optimizer Skill

> **Category:** Tech Skills > Backend > Rust

## Overview

Profiles and optimizes Rust application performance through benchmarking, SIMD optimization, and zero-copy data processing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [rust-performance-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
rust-performance-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@rust-performance-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Profile with cargo-flamegraph and perf
- Write benchmarks with criterion.rs
- Implement SIMD operations with std::simd
- Design zero-copy parsers with nom or winnow

## Technology Standards Applied

- **criterion.rs**: Statistical benchmarking framework
- **Flamegraph**: CPU profiling visualization
- **SIMD**: Portable SIMD operations in Rust