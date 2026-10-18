# Acceptance Criteria Definer -- Workspace Configuration

## Overview
This workspace includes the **Acceptance Criteria Definer** agent. Use when defining testable acceptance criteria for user stories using Given/When/Then or equivalent formats.

## Agent Invocation
- Use `@acceptance-criteria-definer` to invoke the agent directly
- Use `/acceptance-criteria-definer.prompt` for guided workflow prompts
- Use `/acceptance-criteria-definer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ACCEPTANCE_C_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `ACCEPTANCE_C_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `ACCEPTANCE_C_PARALLEL` | `true` | Run tests in parallel when possible |
| `ACCEPTANCE_C_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `ACCEPTANCE_C_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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