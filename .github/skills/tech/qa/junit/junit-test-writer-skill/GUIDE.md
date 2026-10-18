# JUnit Test Writer Skill

> **Category:** Tech Skills > QA > JUnit

## Overview

Writes structured unit tests with JUnit 5 including lifecycle methods, assertions, and test organization for Java applications

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [junit-test-writer-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
junit-test-writer-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@junit-test-writer` agent from the Independent Agents catalogue.

## Key Capabilities

- Write tests with @Test and assertions
- Implement lifecycle with @BeforeEach, @AfterEach
- Organize with @Nested classes and @DisplayName
- Use assertAll for grouped assertions

## Technology Standards Applied

- **JUnit 5**: Jupiter API test patterns
- **Assertions**: JUnit assertion patterns and assertAll
- **Test Lifecycle**: Lifecycle callback order and usage