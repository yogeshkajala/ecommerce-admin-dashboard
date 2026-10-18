# Defect Analyst -- Workspace Configuration

## Overview
This workspace includes the **Defect Analyst** agent. Analyze defects: root cause, severity distribution, fix rate, escape analysis.

## Agent Invocation
- Use `@defect-analyst` to invoke the agent directly
- Use `/defect-analyst.prompt` for guided workflow prompts
- Use `/defect-analyst-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEFECT_ANALY_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `DEFECT_ANALY_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `DEFECT_ANALY_PARALLEL` | `true` | Run tests in parallel when possible |
| `DEFECT_ANALY_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `DEFECT_ANALY_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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