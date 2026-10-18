# Feature Developer -- Workspace Configuration

## Overview
This workspace includes the **Feature Developer** agent. Use when implementing features with code generation, code review, integration testing, and documentation.

## Agent Invocation
- Use `@feature-developer` to invoke the agent directly
- Use `/feature-developer.prompt` for guided workflow prompts
- Use `/feature-developer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FEATURE_DEVE_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FEATURE_DEVE_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FEATURE_DEVE_PARALLEL` | `true` | Run tests in parallel when possible |
| `FEATURE_DEVE_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FEATURE_DEVE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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