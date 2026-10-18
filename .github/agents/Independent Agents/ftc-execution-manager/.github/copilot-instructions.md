# Ftc Execution Manager -- Workspace Configuration

## Overview
This workspace includes the **Ftc Execution Manager** agent. Track test execution: run tests, record results, calculate coverage, and report metrics.

## Agent Invocation
- Use `@ftc-execution-manager` to invoke the agent directly
- Use `/ftc-execution-manager.prompt` for guided workflow prompts
- Use `/ftc-execution-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FTC_EXECUTIO_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FTC_EXECUTIO_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FTC_EXECUTIO_PARALLEL` | `true` | Run tests in parallel when possible |
| `FTC_EXECUTIO_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FTC_EXECUTIO_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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