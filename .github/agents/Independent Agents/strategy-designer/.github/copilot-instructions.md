# Strategy Designer -- Workspace Configuration

## Overview
This workspace includes the **Strategy Designer** agent. Design comprehensive test strategy covering all test types and levels.

## Agent Invocation
- Use `@strategy-designer` to invoke the agent directly
- Use `/strategy-designer.prompt` for guided workflow prompts
- Use `/strategy-designer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `STRATEGY_DES_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `STRATEGY_DES_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `STRATEGY_DES_PARALLEL` | `true` | Run tests in parallel when possible |
| `STRATEGY_DES_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `STRATEGY_DES_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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