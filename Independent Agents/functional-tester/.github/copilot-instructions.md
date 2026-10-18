# Functional Tester -- Workspace Configuration

## Overview
This workspace includes the **Functional Tester** agent. Use when executing functional tests across unit, integration, E2E, and API contract levels.

## Agent Invocation
- Use `@functional-tester` to invoke the agent directly
- Use `/functional-tester.prompt` for guided workflow prompts
- Use `/functional-tester-skill` skill for domain knowledge

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