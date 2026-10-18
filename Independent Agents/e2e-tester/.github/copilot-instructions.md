# E2e Tester -- Workspace Configuration

## Overview
This workspace includes the **E2e Tester** agent. Execute end-to-end tests simulating real user workflows across the full stack.

## Agent Invocation
- Use `@e2e-tester` to invoke the agent directly
- Use `/e2e-tester.prompt` for guided workflow prompts
- Use `/e2e-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `E2E_TESTER_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `E2E_TESTER_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `E2E_TESTER_PARALLEL` | `true` | Run tests in parallel when possible |
| `E2E_TESTER_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `E2E_TESTER_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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