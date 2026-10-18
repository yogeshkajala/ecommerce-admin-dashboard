# Parity Tester -- Workspace Configuration

## Overview
This workspace includes the **Parity Tester** agent. Test output parity: same inputs must produce same outputs as legacy system.

## Agent Invocation
- Use `@parity-tester` to invoke the agent directly
- Use `/parity-tester.prompt` for guided workflow prompts
- Use `/parity-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `PARITY_TESTE_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `PARITY_TESTE_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `PARITY_TESTE_PARALLEL` | `true` | Run tests in parallel when possible |
| `PARITY_TESTE_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `PARITY_TESTE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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