# Feature Tester -- Workspace Configuration

## Overview
This workspace includes the **Feature Tester** agent. Use when testing new features including unit tests, integration tests, regression tests, and user acceptance testing.

## Agent Invocation
- Use `@feature-tester` to invoke the agent directly
- Use `/feature-tester.prompt` for guided workflow prompts
- Use `/feature-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FEATURE_TEST_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FEATURE_TEST_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FEATURE_TEST_PARALLEL` | `true` | Run tests in parallel when possible |
| `FEATURE_TEST_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FEATURE_TEST_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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