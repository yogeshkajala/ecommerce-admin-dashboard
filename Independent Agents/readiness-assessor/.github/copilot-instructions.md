# Readiness Assessor -- Workspace Configuration

## Overview
This workspace includes the **Readiness Assessor** agent. Assess requirements completeness, quality, testability, and readiness for development.

## Agent Invocation
- Use `@readiness-assessor` to invoke the agent directly
- Use `/readiness-assessor.prompt` for guided workflow prompts
- Use `/readiness-assessor-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `READINESS_AS_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `READINESS_AS_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `READINESS_AS_PARALLEL` | `true` | Run tests in parallel when possible |
| `READINESS_AS_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `READINESS_AS_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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