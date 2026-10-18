# Regression Executor -- Workspace Configuration

## Overview
This workspace includes the **Regression Executor** agent. Execute regression test suites, analyze test results, identify failure patterns, and track test reliability metrics over time.

## Agent Invocation
- Use `@regression-executor` to invoke the agent directly
- Use `/regression-executor.prompt` for guided workflow prompts
- Use `/regression-executor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REGRESSION_E_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `REGRESSION_E_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `REGRESSION_E_PARALLEL` | `true` | Run tests in parallel when possible |
| `REGRESSION_E_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `REGRESSION_E_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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