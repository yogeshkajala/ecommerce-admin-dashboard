# Test Designer -- Workspace Configuration

## Overview
This workspace includes the **Test Designer** agent. Use when designing comprehensive test strategies covering all test levels with risk-based prioritization.

## Agent Invocation
- Use `@test-designer` to invoke the agent directly
- Use `/test-designer.prompt` for guided workflow prompts
- Use `/test-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEST_DESIGNE_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TEST_DESIGNE_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TEST_DESIGNE_PARALLEL` | `true` | Run tests in parallel when possible |
| `TEST_DESIGNE_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TEST_DESIGNE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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