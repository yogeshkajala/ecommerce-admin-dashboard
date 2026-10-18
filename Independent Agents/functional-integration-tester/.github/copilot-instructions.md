# Functional Integration Tester -- Workspace Configuration

## Overview
This workspace includes the **Functional Integration Tester** agent. Execute integration tests validating component interactions and data flow.

## Agent Invocation
- Use `@functional-integration-tester` to invoke the agent directly
- Use `/functional-integration-tester.prompt` for guided workflow prompts
- Use `/functional-integration-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FUNCTIONAL_I_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FUNCTIONAL_I_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FUNCTIONAL_I_PARALLEL` | `true` | Run tests in parallel when possible |
| `FUNCTIONAL_I_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FUNCTIONAL_I_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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