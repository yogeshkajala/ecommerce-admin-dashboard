# Modernization Tester -- Workspace Configuration

## Overview
This workspace includes the **Modernization Tester** agent. Use when testing modernized cloud applications including integration tests, load tests, chaos engineering, and security testing.

## Agent Invocation
- Use `@modernization-tester` to invoke the agent directly
- Use `/modernization-tester.prompt` for guided workflow prompts
- Use `/modernization-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `MODERNIZATIO_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `MODERNIZATIO_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `MODERNIZATIO_PARALLEL` | `true` | Run tests in parallel when possible |
| `MODERNIZATIO_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `MODERNIZATIO_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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