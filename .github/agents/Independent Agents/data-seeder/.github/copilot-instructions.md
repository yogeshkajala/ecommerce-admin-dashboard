# Data Seeder -- Workspace Configuration

## Overview
This workspace includes the **Data Seeder** agent. Use when seeding test environments with baseline data, reference configurations, and initial state.

## Agent Invocation
- Use `@data-seeder` to invoke the agent directly
- Use `/data-seeder.prompt` for guided workflow prompts
- Use `/data-seeder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATA_SEEDER_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `DATA_SEEDER_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `DATA_SEEDER_PARALLEL` | `true` | Run tests in parallel when possible |
| `DATA_SEEDER_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `DATA_SEEDER_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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