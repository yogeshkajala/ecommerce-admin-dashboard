# Smoke Test Runner -- Workspace Configuration

## Overview
This workspace includes the **Smoke Test Runner** agent. Use when running smoke tests to verify basic health and availability of deployment artifacts before full testing.

## Agent Invocation
- Use `@smoke-test-runner` to invoke the agent directly
- Use `/smoke-test-runner.prompt` for guided workflow prompts
- Use `/smoke-test-runner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SMOKE_TEST_R_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `SMOKE_TEST_R_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `SMOKE_TEST_R_PARALLEL` | `true` | Run tests in parallel when possible |
| `SMOKE_TEST_R_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `SMOKE_TEST_R_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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