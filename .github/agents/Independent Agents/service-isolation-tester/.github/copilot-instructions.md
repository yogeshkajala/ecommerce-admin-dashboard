# Service Isolation Tester -- Workspace Configuration

## Overview
This workspace includes the **Service Isolation Tester** agent. Use when verifying that extracted services are truly independent with no shared state or circular dependencies.

## Agent Invocation
- Use `@service-isolation-tester` to invoke the agent directly
- Use `/service-isolation-tester.prompt` for guided workflow prompts
- Use `/service-isolation-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SERVICE_ISOL_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `SERVICE_ISOL_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `SERVICE_ISOL_PARALLEL` | `true` | Run tests in parallel when possible |
| `SERVICE_ISOL_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `SERVICE_ISOL_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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