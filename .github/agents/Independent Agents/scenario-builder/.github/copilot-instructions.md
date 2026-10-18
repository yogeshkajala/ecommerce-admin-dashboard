# Scenario Builder -- Workspace Configuration

## Overview
This workspace includes the **Scenario Builder** agent. Build comprehensive test scenarios including positive, negative, edge case, and boundary value tests from requirements and specifications.

## Agent Invocation
- Use `@scenario-builder` to invoke the agent directly
- Use `/scenario-builder.prompt` for guided workflow prompts
- Use `/scenario-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SCENARIO_BUI_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `SCENARIO_BUI_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `SCENARIO_BUI_PARALLEL` | `true` | Run tests in parallel when possible |
| `SCENARIO_BUI_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `SCENARIO_BUI_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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