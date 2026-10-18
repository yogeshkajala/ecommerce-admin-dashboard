# Unit Test Writer -- Workspace Configuration

## Overview
This workspace includes the **Unit Test Writer** agent. Use when writing unit tests for new feature code including happy path, edge cases, and error handling.

## Agent Invocation
- Use `@unit-test-writer` to invoke the agent directly
- Use `/unit-test-writer.prompt` for guided workflow prompts
- Use `/unit-test-writer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UNIT_TEST_WR_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `UNIT_TEST_WR_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `UNIT_TEST_WR_PARALLEL` | `true` | Run tests in parallel when possible |
| `UNIT_TEST_WR_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `UNIT_TEST_WR_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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