# Test Executor -- Workspace Configuration

## Overview
This workspace includes the **Test Executor** agent. Use when executing test suites, collecting pass/fail results, identifying flaky tests, and generating execution logs.

## Agent Invocation
- Use `@test-executor` to invoke the agent directly
- Use `/test-executor.prompt` for guided workflow prompts
- Use `/test-executor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEST_EXECUTO_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TEST_EXECUTO_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TEST_EXECUTO_PARALLEL` | `true` | Run tests in parallel when possible |
| `TEST_EXECUTO_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TEST_EXECUTO_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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