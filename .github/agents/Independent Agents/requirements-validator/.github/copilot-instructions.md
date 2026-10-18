# Requirements Validator -- Workspace Configuration

## Overview
This workspace includes the **Requirements Validator** agent. Use when validating requirements completeness, traceability coverage, ID consistency, ambiguity markers, and development readiness.

## Agent Invocation
- Use `@requirements-validator` to invoke the agent directly
- Use `/requirements-validator.prompt` for guided workflow prompts
- Use `/requirements-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REQUIREMENTS_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `REQUIREMENTS_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `REQUIREMENTS_PARALLEL` | `true` | Run tests in parallel when possible |
| `REQUIREMENTS_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `REQUIREMENTS_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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