# Compatibility Tester -- Workspace Configuration

## Overview
This workspace includes the **Compatibility Tester** agent. Use when testing compatibility of dependencies, APIs, and integrations against an upgrade target version.

## Agent Invocation
- Use `@compatibility-tester` to invoke the agent directly
- Use `/compatibility-tester.prompt` for guided workflow prompts
- Use `/compatibility-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COMPATIBILIT_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `COMPATIBILIT_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `COMPATIBILIT_PARALLEL` | `true` | Run tests in parallel when possible |
| `COMPATIBILIT_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `COMPATIBILIT_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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