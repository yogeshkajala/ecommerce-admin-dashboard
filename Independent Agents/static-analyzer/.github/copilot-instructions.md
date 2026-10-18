# Static Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Static Analyzer** agent. Use when running static analysis for cyclomatic complexity, code duplication, security vulnerabilities, dependency risks, and code coverage metrics.

## Agent Invocation
- Use `@static-analyzer` to invoke the agent directly
- Use `/static-analyzer.prompt` for guided workflow prompts
- Use `/static-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `STATIC_ANALY_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `STATIC_ANALY_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `STATIC_ANALY_PARALLEL` | `true` | Run tests in parallel when possible |
| `STATIC_ANALY_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `STATIC_ANALY_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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