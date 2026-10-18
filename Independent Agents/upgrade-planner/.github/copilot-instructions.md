# Upgrade Planner -- Workspace Configuration

## Overview
This workspace includes the **Upgrade Planner** agent. Use when planning upgrade execution path, generating migration scripts, building rollback plans, and designing test strategies.

## Agent Invocation
- Use `@upgrade-planner` to invoke the agent directly
- Use `/upgrade-planner.prompt` for guided workflow prompts
- Use `/upgrade-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UPGRADE_PLAN_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `UPGRADE_PLAN_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `UPGRADE_PLAN_PARALLEL` | `true` | Run tests in parallel when possible |
| `UPGRADE_PLAN_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `UPGRADE_PLAN_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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