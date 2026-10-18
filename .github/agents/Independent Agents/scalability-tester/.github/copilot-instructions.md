# Scalability Tester -- Workspace Configuration

## Overview
This workspace includes the **Scalability Tester** agent. Use when testing auto-scaling behavior, horizontal scaling limits, and load-based resource allocation.

## Agent Invocation
- Use `@scalability-tester` to invoke the agent directly
- Use `/scalability-tester.prompt` for guided workflow prompts
- Use `/scalability-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SCALABILITY__FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `SCALABILITY__COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `SCALABILITY__PARALLEL` | `true` | Run tests in parallel when possible |
| `SCALABILITY__MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `SCALABILITY__REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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