# Coverage Reporter -- Workspace Configuration

## Overview
This workspace includes the **Coverage Reporter** agent. Use when reporting code coverage by test level, module, and metric (line, branch, function) with gap identification.

## Agent Invocation
- Use `@coverage-reporter` to invoke the agent directly
- Use `/coverage-reporter.prompt` for guided workflow prompts
- Use `/coverage-reporter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COVERAGE_REP_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `COVERAGE_REP_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `COVERAGE_REP_PARALLEL` | `true` | Run tests in parallel when possible |
| `COVERAGE_REP_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `COVERAGE_REP_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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