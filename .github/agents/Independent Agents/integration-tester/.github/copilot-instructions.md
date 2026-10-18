# Integration Tester -- Workspace Configuration

## Overview
This workspace includes the **Integration Tester** agent. Use when running integration tests across modernized cloud services to validate API contracts and service interactions.

## Agent Invocation
- Use `@integration-tester` to invoke the agent directly
- Use `/integration-tester.prompt` for guided workflow prompts
- Use `/integration-tester-skill` skill for domain knowledge

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