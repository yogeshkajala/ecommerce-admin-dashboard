# Error Rate Tracker -- Workspace Configuration

## Overview
This workspace includes the **Error Rate Tracker** agent. Use when tracking error rates after deployment to detect new errors, error spikes, and regression patterns.

## Agent Invocation
- Use `@error-rate-tracker` to invoke the agent directly
- Use `/error-rate-tracker.prompt` for guided workflow prompts
- Use `/error-rate-tracker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ERROR_RATE_T_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `ERROR_RATE_T_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `ERROR_RATE_T_PARALLEL` | `true` | Run tests in parallel when possible |
| `ERROR_RATE_T_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `ERROR_RATE_T_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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