# Framework Builder -- Workspace Configuration

## Overview
This workspace includes the **Framework Builder** agent. Use when building or configuring test automation frameworks with base utilities and project conventions.

## Agent Invocation
- Use `@framework-builder` to invoke the agent directly
- Use `/framework-builder.prompt` for guided workflow prompts
- Use `/framework-builder-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FRAMEWORK_BU_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FRAMEWORK_BU_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FRAMEWORK_BU_PARALLEL` | `true` | Run tests in parallel when possible |
| `FRAMEWORK_BU_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FRAMEWORK_BU_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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