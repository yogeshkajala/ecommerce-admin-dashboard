# JUnit Integration Tester Skill

> **Category:** Tech Skills > QA > JUnit

## Overview

Implements integration tests with JUnit 5 using Testcontainers, Spring Test, and database test utilities for realistic testing

## Quick Start

1. Copy this skill folder to your workspace under `.github/skills/`
2. Reference in agent files: `skills: [junit-integration-tester-skill]`
3. The skill activates automatically when the agent is invoked

## Structure

```text
junit-integration-tester-skill/
  SKILL.md    # Skill definition with procedures and standards
  GUIDE.md    # This guide
```

## Companion Agent

This skill is designed to work with the `@junit-integration-tester` agent from the Independent Agents catalogue.

## Key Capabilities

- Configure Testcontainers for database and service tests
- Use @SpringBootTest for full context testing
- Implement test slices: @DataJpaTest, @WebMvcTest
- Configure test databases with @DynamicPropertySource

## Technology Standards Applied

- **Testcontainers**: Container-based integration testing
- **Spring Test**: Spring Boot test slice patterns
- **Test Data**: Test data management and cleanup