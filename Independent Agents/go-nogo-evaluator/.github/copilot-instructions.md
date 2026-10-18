# Go Nogo Evaluator -- Workspace Configuration

## Overview
This workspace includes the **Go Nogo Evaluator** agent. Use when evaluating release readiness with checklist covering tests, security, performance, rollback, and team availability.

## Agent Invocation
- Use `@go-nogo-evaluator` to invoke the agent directly
- Use `/go-nogo-evaluator.prompt` for guided workflow prompts
- Use `/go-nogo-evaluator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `GO_NOGO_EVAL_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `GO_NOGO_EVAL_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `GO_NOGO_EVAL_PARALLEL` | `true` | Run tests in parallel when possible |
| `GO_NOGO_EVAL_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `GO_NOGO_EVAL_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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