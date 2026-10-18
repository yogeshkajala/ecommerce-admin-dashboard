# Test Data Manager -- Workspace Configuration

## Overview
This workspace includes the **Test Data Manager** agent. Use when managing test data -- creating fixtures, factories, seed scripts, and ensuring data isolation across test runs.

## Agent Invocation
- Use `@test-data-manager` to invoke the agent directly
- Use `/test-data-manager.prompt` for guided workflow prompts
- Use `/test-data-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEST_DATA_MA_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TEST_DATA_MA_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TEST_DATA_MA_PARALLEL` | `true` | Run tests in parallel when possible |
| `TEST_DATA_MA_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TEST_DATA_MA_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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