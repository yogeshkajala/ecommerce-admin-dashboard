# Environment Planner -- Workspace Configuration

## Overview
This workspace includes the **Environment Planner** agent. Use when planning test environments including infrastructure, data, configuration, and service dependencies.

## Agent Invocation
- Use `@environment-planner` to invoke the agent directly
- Use `/environment-planner.prompt` for guided workflow prompts
- Use `/environment-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ENVIRONMENT__FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `ENVIRONMENT__COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `ENVIRONMENT__PARALLEL` | `true` | Run tests in parallel when possible |
| `ENVIRONMENT__MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `ENVIRONMENT__REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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