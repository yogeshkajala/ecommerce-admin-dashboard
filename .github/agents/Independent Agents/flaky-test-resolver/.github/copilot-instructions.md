# Flaky Test Resolver -- Workspace Configuration

## Overview
This workspace includes the **Flaky Test Resolver** agent. Use when diagnosing and resolving flaky tests that produce inconsistent pass/fail results.

## Agent Invocation
- Use `@flaky-test-resolver` to invoke the agent directly
- Use `/flaky-test-resolver.prompt` for guided workflow prompts
- Use `/flaky-test-resolver-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FLAKY_TEST_R_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FLAKY_TEST_R_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FLAKY_TEST_R_PARALLEL` | `true` | Run tests in parallel when possible |
| `FLAKY_TEST_R_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FLAKY_TEST_R_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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