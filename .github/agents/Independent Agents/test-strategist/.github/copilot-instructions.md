# Test Strategist -- Workspace Configuration

## Overview
This workspace includes the **Test Strategist** agent. Use when designing risk-based test strategies, analyzing coverage gaps, planning environments, and designing test data.

## Agent Invocation
- Use `@test-strategist` to invoke the agent directly
- Use `/test-strategist.prompt` for guided workflow prompts
- Use `/test-strategist-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEST_STRATEG_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TEST_STRATEG_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TEST_STRATEG_PARALLEL` | `true` | Run tests in parallel when possible |
| `TEST_STRATEG_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TEST_STRATEG_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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