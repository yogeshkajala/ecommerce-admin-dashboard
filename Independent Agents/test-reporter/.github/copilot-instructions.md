# Test Reporter -- Workspace Configuration

## Overview
This workspace includes the **Test Reporter** agent. Use when generating test reports with coverage metrics, pass/fail rates, defect analytics, and quality gate go/no-go recommendations.

## Agent Invocation
- Use `@test-reporter` to invoke the agent directly
- Use `/test-reporter.prompt` for guided workflow prompts
- Use `/test-reporter-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEST_REPORTE_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TEST_REPORTE_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TEST_REPORTE_PARALLEL` | `true` | Run tests in parallel when possible |
| `TEST_REPORTE_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TEST_REPORTE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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