# Integration Test Builder -- Workspace Configuration

## Overview
This workspace includes the **Integration Test Builder** agent. Use when building integration tests that verify component interactions, data flow, and error propagation.

## Agent Invocation
- Use `@integration-test-builder` to invoke the agent directly
- Use `/integration-test-builder.prompt` for guided workflow prompts
- Use `/integration-test-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `INTEGRATION__FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `INTEGRATION__COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `INTEGRATION__PARALLEL` | `true` | Run tests in parallel when possible |
| `INTEGRATION__MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `INTEGRATION__REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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