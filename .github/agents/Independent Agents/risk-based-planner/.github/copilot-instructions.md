# Risk Based Planner -- Workspace Configuration

## Overview
This workspace includes the **Risk Based Planner** agent. Use when creating risk-based test plans that prioritize testing effort based on business impact and likelihood of failure.

## Agent Invocation
- Use `@risk-based-planner` to invoke the agent directly
- Use `/risk-based-planner.prompt` for guided workflow prompts
- Use `/risk-based-planner-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `RISK_BASED_P_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `RISK_BASED_P_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `RISK_BASED_P_PARALLEL` | `true` | Run tests in parallel when possible |
| `RISK_BASED_P_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `RISK_BASED_P_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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