# Env Cleanup Agent -- Workspace Configuration

## Overview
This workspace includes the **Env Cleanup Agent** agent. Use when cleaning up test environments -- releasing resources, deleting temporary data, and verifying complete removal.

## Agent Invocation
- Use `@env-cleanup-agent` to invoke the agent directly
- Use `/env-cleanup-agent.prompt` for guided workflow prompts
- Use `/env-cleanup-agent-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ENV_CLEANUP__FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `ENV_CLEANUP__COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `ENV_CLEANUP__PARALLEL` | `true` | Run tests in parallel when possible |
| `ENV_CLEANUP__MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `ENV_CLEANUP__REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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