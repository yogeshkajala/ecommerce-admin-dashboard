# JUnit Parameterized Tester Skill

> **Category:** Tech Skills > QA > JUnit

## Overview

Creates parameterized tests with JUnit 5 using @ParameterizedTest, various sources, and custom argument converters

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [junit-parameterized-tester-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
junit-parameterized-tester-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@junit-parameterized-tester` agent from the Independent Agents catalogue.

## Key Capabilities

- Write parameterized tests with @ValueSource, @CsvSource
- Implement @MethodSource for complex parameters
- Create custom ArgumentsProvider implementations
- Use @CsvFileSource for external test data

## Technology Standards Applied

- **Parameterized Tests**: JUnit 5 parameterized test patterns
- **Argument Sources**: Built-in and custom argument providers
- **Display Names**: Readable test names for parameterized tests