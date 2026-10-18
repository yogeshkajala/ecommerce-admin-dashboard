# Test Suite Runner -- Workspace Configuration

## Overview
This workspace includes the **Test Suite Runner** agent. Use when executing full test suite after upgrade to verify no regressions.

## Agent Invocation
- Use `@test-suite-runner` to invoke the agent directly
- Use `/test-suite-runner.prompt` for guided workflow prompts
- Use `/test-suite-runner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEST_SUITE_R_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TEST_SUITE_R_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TEST_SUITE_R_PARALLEL` | `true` | Run tests in parallel when possible |
| `TEST_SUITE_R_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TEST_SUITE_R_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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