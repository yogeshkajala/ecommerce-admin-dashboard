# Ftc Generator -- Workspace Configuration

## Overview
This workspace includes the **Ftc Generator** agent. Generate functional test cases from requirements, user stories, and acceptance criteria.

## Agent Invocation
- Use `@ftc-generator` to invoke the agent directly
- Use `/ftc-generator.prompt` for guided workflow prompts
- Use `/ftc-generator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FTC_GENERATO_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FTC_GENERATO_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FTC_GENERATO_PARALLEL` | `true` | Run tests in parallel when possible |
| `FTC_GENERATO_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FTC_GENERATO_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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