# Rust CLI Builder Skill

> **Category:** Tech Skills > Backend > Rust

## Overview

Builds command-line applications in Rust with clap for argument parsing, indicatif for progress, and cross-platform compatibility

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [rust-cli-builder-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
rust-cli-builder-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@rust-cli-builder` agent from the Independent Agents catalogue.

## Key Capabilities

- Parse arguments with clap derive macros
- Build interactive progress indicators with indicatif
- Implement colored output with termcolor
- Design subcommand architectures

## Technology Standards Applied

- **clap**: Command-line argument parsing patterns
- **CLI Guidelines**: POSIX and GNU CLI convention compliance
- **Cross-Platform**: Platform-independent path and I/O handling