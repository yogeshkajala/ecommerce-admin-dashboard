# Env Provisioner -- Workspace Configuration

## Overview
This workspace includes the **Env Provisioner** agent. Use when provisioning test environments from infrastructure templates and specifications.

## Agent Invocation
- Use `@env-provisioner` to invoke the agent directly
- Use `/env-provisioner.prompt` for guided workflow prompts
- Use `/env-provisioner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `ENV_PROVISIO_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `ENV_PROVISIO_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `ENV_PROVISIO_PARALLEL` | `true` | Run tests in parallel when possible |
| `ENV_PROVISIO_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `ENV_PROVISIO_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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