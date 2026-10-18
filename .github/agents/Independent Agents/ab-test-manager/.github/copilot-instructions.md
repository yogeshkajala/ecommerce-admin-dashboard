# Ab Test Manager -- Workspace Configuration

## Overview
This workspace includes the **Ab Test Manager** agent. Use when designing and managing A/B tests for new features including experiment setup, monitoring, and statistical analysis.

## Agent Invocation
- Use `@ab-test-manager` to invoke the agent directly
- Use `/ab-test-manager.prompt` for guided workflow prompts
- Use `/ab-test-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `AB_TEST_MANA_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `AB_TEST_MANA_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `AB_TEST_MANA_PARALLEL` | `true` | Run tests in parallel when possible |
| `AB_TEST_MANA_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `AB_TEST_MANA_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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