# Upgrade Tester -- Workspace Configuration

## Overview
This workspace includes the **Upgrade Tester** agent. Use when testing upgrades -- compatibility testing, regression testing, performance comparison, and rollback verification.

## Agent Invocation
- Use `@upgrade-tester` to invoke the agent directly
- Use `/upgrade-tester.prompt` for guided workflow prompts
- Use `/upgrade-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `UPGRADE_TEST_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `UPGRADE_TEST_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `UPGRADE_TEST_PARALLEL` | `true` | Run tests in parallel when possible |
| `UPGRADE_TEST_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `UPGRADE_TEST_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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