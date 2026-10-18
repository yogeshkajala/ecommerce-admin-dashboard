# Unit Test Generator -- Workspace Configuration

## Overview
This workspace includes the **Unit Test Generator** agent. Use when generating unit tests with positive, negative, and edge case scenarios targeting 80%+ line coverage.

## Agent Invocation
- Use `@unit-test-generator` to invoke the agent directly
- Use `/unit-test-generator.prompt` for guided workflow prompts
- Use `/unit-test-generator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UNIT_TEST_GE_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `UNIT_TEST_GE_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `UNIT_TEST_GE_PARALLEL` | `true` | Run tests in parallel when possible |
| `UNIT_TEST_GE_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `UNIT_TEST_GE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

## Key Conventions
- All test outputs must include coverage metrics
- Test failures must include reproduction steps
- Mock external dependencies by default
- Follow Arrange-Act-Assert pattern
- Report format follows configured standard

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations