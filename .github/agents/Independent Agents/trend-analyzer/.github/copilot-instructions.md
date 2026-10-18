# Trend Analyzer -- Workspace Configuration

## Overview
This workspace includes the **Trend Analyzer** agent. Analyze quality trends: defect density, test pass rate, coverage over time.

## Agent Invocation
- Use `@trend-analyzer` to invoke the agent directly
- Use `/trend-analyzer.prompt` for guided workflow prompts
- Use `/trend-analyzer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TREND_ANALYZ_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TREND_ANALYZ_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TREND_ANALYZ_PARALLEL` | `true` | Run tests in parallel when possible |
| `TREND_ANALYZ_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TREND_ANALYZ_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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