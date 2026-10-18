# Defect Validator -- Workspace Configuration

## Overview
This workspace includes the **Defect Validator** agent. Use when validating defect fixes, running targeted verification tests, executing regression suites, or confirming fix effectiveness across environments.

## Agent Invocation
- Use `@defect-validator` to invoke the agent directly
- Use `/defect-validator.prompt` for guided workflow prompts
- Use `/defect-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEFECT_VALID_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `DEFECT_VALID_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `DEFECT_VALID_PARALLEL` | `true` | Run tests in parallel when possible |
| `DEFECT_VALID_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `DEFECT_VALID_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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