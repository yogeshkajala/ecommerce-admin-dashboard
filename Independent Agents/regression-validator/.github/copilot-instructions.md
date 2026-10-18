# Regression Validator -- Workspace Configuration

## Overview
This workspace includes the **Regression Validator** agent. Run full regression suite validating all functionality works post-upgrade.

## Agent Invocation
- Use `@regression-validator` to invoke the agent directly
- Use `/regression-validator.prompt` for guided workflow prompts
- Use `/regression-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REGRESSION_V_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `REGRESSION_V_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `REGRESSION_V_PARALLEL` | `true` | Run tests in parallel when possible |
| `REGRESSION_V_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `REGRESSION_V_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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