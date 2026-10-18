# Test Engineer -- Workspace Configuration

## Overview
This workspace includes the **Test Engineer** agent. Use when designing test strategies, generating test cases, executing test suites, and reporting test results with coverage metrics.

## Agent Invocation
- Use `@test-engineer` to invoke the agent directly
- Use `/test-engineer.prompt` for guided workflow prompts
- Use `/test-engineer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEST_ENGINEE_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TEST_ENGINEE_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TEST_ENGINEE_PARALLEL` | `true` | Run tests in parallel when possible |
| `TEST_ENGINEE_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TEST_ENGINEE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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