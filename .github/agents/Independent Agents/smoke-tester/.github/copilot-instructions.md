# Smoke Tester -- Workspace Configuration

## Overview
This workspace includes the **Smoke Tester** agent. Use when running smoke tests on critical business flows immediately after deployment.

## Agent Invocation
- Use `@smoke-tester` to invoke the agent directly
- Use `/smoke-tester.prompt` for guided workflow prompts
- Use `/smoke-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SMOKE_TESTER_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `SMOKE_TESTER_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `SMOKE_TESTER_PARALLEL` | `true` | Run tests in parallel when possible |
| `SMOKE_TESTER_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `SMOKE_TESTER_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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