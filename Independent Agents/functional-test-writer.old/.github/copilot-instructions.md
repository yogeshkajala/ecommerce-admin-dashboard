# Functional Test Writer -- Workspace Configuration

## Overview
This workspace includes the **Functional Test Writer** agent. Generate functional and integration tests: E2E scenarios, BDD features, API tests, and acceptance criteria validation.

## Agent Invocation
- Use `@functional-test-writer` to invoke the agent directly
- Use `/functional-test-writer.prompt` for guided workflow prompts
- Use `/functional-test-writer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FUNCTIONAL_T_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FUNCTIONAL_T_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FUNCTIONAL_T_PARALLEL` | `true` | Run tests in parallel when possible |
| `FUNCTIONAL_T_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FUNCTIONAL_T_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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