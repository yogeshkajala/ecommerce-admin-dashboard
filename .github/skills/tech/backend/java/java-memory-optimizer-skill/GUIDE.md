# Java Memory Optimizer Skill

> **Category:** Tech Skills > Backend > Java

## Overview

Analyzes and optimizes JVM memory usage through heap tuning, garbage collection configuration, and memory leak detection

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [java-memory-optimizer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
java-memory-optimizer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@java-memory-optimizer` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze heap dumps with Eclipse MAT or VisualVM
- Configure garbage collectors: G1, ZGC, Shenandoah
- Identify memory leaks with allocation tracking
- Optimize object allocation and pooling patterns

## Technology Standards Applied

- **JVM Tuning**: JVM memory management and GC tuning guidelines
- **GC Algorithms**: G1, ZGC, Shenandoah selection criteria
- **Memory Analysis**: Heap dump analysis and leak detection patterns