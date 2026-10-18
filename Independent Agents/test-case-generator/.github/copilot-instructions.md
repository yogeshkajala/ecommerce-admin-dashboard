# Test Case Generator -- Workspace Configuration

## Overview
This workspace includes the **Test Case Generator** agent. Use when generating test cases from requirements including positive, negative, edge, boundary, and error-handling scenarios.

## Agent Invocation
- Use `@test-case-generator` to invoke the agent directly
- Use `/test-case-generator.prompt` for guided workflow prompts
- Use `/test-case-generator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEST_CASE_GE_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TEST_CASE_GE_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TEST_CASE_GE_PARALLEL` | `true` | Run tests in parallel when possible |
| `TEST_CASE_GE_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TEST_CASE_GE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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