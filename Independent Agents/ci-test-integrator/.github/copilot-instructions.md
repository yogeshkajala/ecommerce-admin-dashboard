# Ci Test Integrator -- Workspace Configuration

## Overview
This workspace includes the **Ci Test Integrator** agent. Use when integrating test automation into CI/CD pipelines with stages, gates, and reporting.

## Agent Invocation
- Use `@ci-test-integrator` to invoke the agent directly
- Use `/ci-test-integrator.prompt` for guided workflow prompts
- Use `/ci-test-integrator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CI_TEST_INTE_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `CI_TEST_INTE_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `CI_TEST_INTE_PARALLEL` | `true` | Run tests in parallel when possible |
| `CI_TEST_INTE_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `CI_TEST_INTE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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