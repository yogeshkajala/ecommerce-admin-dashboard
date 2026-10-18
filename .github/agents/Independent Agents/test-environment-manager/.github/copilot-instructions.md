# Test Environment Manager -- Workspace Configuration

## Overview
This workspace includes the **Test Environment Manager** agent. Use when managing test environments -- provisioning, data seeding, health monitoring, and cleanup.

## Agent Invocation
- Use `@test-environment-manager` to invoke the agent directly
- Use `/test-environment-manager.prompt` for guided workflow prompts
- Use `/test-environment-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEST_ENVIRON_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TEST_ENVIRON_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TEST_ENVIRON_PARALLEL` | `true` | Run tests in parallel when possible |
| `TEST_ENVIRON_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TEST_ENVIRON_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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