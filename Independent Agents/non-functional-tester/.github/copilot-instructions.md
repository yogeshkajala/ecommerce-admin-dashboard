# Non Functional Tester -- Workspace Configuration

## Overview
This workspace includes the **Non Functional Tester** agent. Use when executing non-functional tests including load/performance, security scanning, accessibility auditing, and compatibility testing.

## Agent Invocation
- Use `@non-functional-tester` to invoke the agent directly
- Use `/non-functional-tester.prompt` for guided workflow prompts
- Use `/non-functional-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `NON_FUNCTION_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `NON_FUNCTION_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `NON_FUNCTION_PARALLEL` | `true` | Run tests in parallel when possible |
| `NON_FUNCTION_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `NON_FUNCTION_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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