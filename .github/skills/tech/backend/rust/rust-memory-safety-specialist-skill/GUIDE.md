# Rust Memory Safety Specialist Skill

> **Category:** Tech Skills > Backend > Rust

## Overview

Implements memory-safe Rust code using ownership, borrowing, lifetimes, and smart pointer patterns for zero-cost abstractions

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [rust-memory-safety-specialist-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
rust-memory-safety-specialist-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@rust-memory-safety-specialist` agent from the Independent Agents catalogue.

## Key Capabilities

- Design ownership hierarchies for complex data structures
- Resolve lifetime annotations for references
- Implement smart pointers: Box, Rc, Arc, RefCell
- Build interior mutability patterns safely

## Technology Standards Applied

- **Rust Ownership**: Ownership, borrowing, and lifetime rules
- **Smart Pointers**: Box, Rc, Arc, and interior mutability patterns
- **Miri**: Undefined behavior detection tool