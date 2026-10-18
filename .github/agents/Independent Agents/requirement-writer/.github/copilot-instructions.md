# Requirement Writer -- Workspace Configuration

## Overview
This workspace includes the **Requirement Writer** agent. Use when writing formal, testable requirement specifications with unique IDs, acceptance criteria, traceability, and MoSCoW prioritization.

## Agent Invocation
- Use `@requirement-writer` to invoke the agent directly
- Use `/requirement-writer.prompt` for guided workflow prompts
- Use `/requirement-writer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `REQUIREMENT__FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `REQUIREMENT__COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `REQUIREMENT__PARALLEL` | `true` | Run tests in parallel when possible |
| `REQUIREMENT__MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `REQUIREMENT__REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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