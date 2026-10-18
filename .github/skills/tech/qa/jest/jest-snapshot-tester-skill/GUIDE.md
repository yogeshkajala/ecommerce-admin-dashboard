# Jest Snapshot Tester Skill

> **Category:** Tech Skills > QA > Jest

## Overview

Implements snapshot testing with Jest for component output verification with proper update workflows and inline snapshots

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [jest-snapshot-tester-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
jest-snapshot-tester-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@jest-snapshot-tester` agent from the Independent Agents catalogue.

## Key Capabilities

- Create snapshot tests for component output
- Use inline snapshots for small test subjects
- Configure custom snapshot serializers
- Manage snapshot updates in code review

## Technology Standards Applied

- **Snapshot Testing**: Jest snapshot testing patterns
- **Inline Snapshots**: Co-located snapshot values
- **Serializers**: Custom snapshot serializer design