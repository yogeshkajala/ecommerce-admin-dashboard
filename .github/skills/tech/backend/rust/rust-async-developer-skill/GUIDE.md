# Rust Async Developer Skill

> **Category:** Tech Skills > Backend > Rust

## Overview

Builds asynchronous Rust applications with Tokio or async-std including futures, task spawning, and async trait implementations

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [rust-async-developer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
rust-async-developer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@rust-async-developer` agent from the Independent Agents catalogue.

## Key Capabilities

- Build async applications with Tokio runtime
- Implement async trait methods
- Design task spawning and cancellation patterns
- Handle async streams with tokio::sync channels

## Technology Standards Applied

- **Tokio**: Tokio runtime patterns and best practices
- **Async Traits**: Async function in trait implementations
- **Futures**: Future combinators and pinning