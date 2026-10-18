# Performance Tester -- Workspace Configuration

## Overview
This workspace includes the **Performance Tester** agent. Use when benchmarking feature performance against baseline metrics to detect degradation.

## Agent Invocation
- Use `@performance-tester` to invoke the agent directly
- Use `/performance-tester.prompt` for guided workflow prompts
- Use `/performance-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PERFORMANCE__FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `PERFORMANCE__COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `PERFORMANCE__PARALLEL` | `true` | Run tests in parallel when possible |
| `PERFORMANCE__MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `PERFORMANCE__REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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