# Production Validator -- Workspace Configuration

## Overview
This workspace includes the **Production Validator** agent. Validate production deployments with smoke tests, canary analysis, health checks, and acceptance criteria verification.

## Agent Invocation
- Use `@production-validator` to invoke the agent directly
- Use `/production-validator.prompt` for guided workflow prompts
- Use `/production-validator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PRODUCTION_V_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `PRODUCTION_V_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `PRODUCTION_V_PARALLEL` | `true` | Run tests in parallel when possible |
| `PRODUCTION_V_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `PRODUCTION_V_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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