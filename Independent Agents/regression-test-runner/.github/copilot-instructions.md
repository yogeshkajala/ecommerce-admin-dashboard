# Regression Test Runner -- Workspace Configuration

## Overview
This workspace includes the **Regression Test Runner** agent. Use when running regression tests to verify new features do not break existing functionality.

## Agent Invocation
- Use `@regression-test-runner` to invoke the agent directly
- Use `/regression-test-runner.prompt` for guided workflow prompts
- Use `/regression-test-runner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REGRESSION_T_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `REGRESSION_T_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `REGRESSION_T_PARALLEL` | `true` | Run tests in parallel when possible |
| `REGRESSION_T_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `REGRESSION_T_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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