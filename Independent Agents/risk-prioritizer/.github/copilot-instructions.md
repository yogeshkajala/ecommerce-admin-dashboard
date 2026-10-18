# Risk Prioritizer -- Workspace Configuration

## Overview
This workspace includes the **Risk Prioritizer** agent. Prioritize test effort based on risk analysis: business impact, complexity, change frequency.

## Agent Invocation
- Use `@risk-prioritizer` to invoke the agent directly
- Use `/risk-prioritizer.prompt` for guided workflow prompts
- Use `/risk-prioritizer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RISK_PRIORIT_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `RISK_PRIORIT_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `RISK_PRIORIT_PARALLEL` | `true` | Run tests in parallel when possible |
| `RISK_PRIORIT_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `RISK_PRIORIT_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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