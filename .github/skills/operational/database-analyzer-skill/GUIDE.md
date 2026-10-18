# Database Analyzer Skill

> **Category:** Generic Skills

## Overview

Analyze shared database: table ownership, cross-domain joins, write patterns.

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [database-analyzer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
database-analyzer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@database-analyzer` agent from the Independent Agents catalogue.

## Key Capabilities

- Analyze complex systems and decompose into manageable components
- Design solutions following established patterns and conventions
- Generate structured artifacts with consistent formatting and quality
- Validate outputs against acceptance criteria and quality gates

## Industry Standards Applied

- **ACID Principles**: Transaction guarantees: Atomicity, Consistency, Isolation, Durability
- **CAP Theorem**: Distributed database trade-offs: Consistency, Availability, Partition tolerance
- **Database Normalization**: Normal forms (1NF-5NF) for relational data integrity
