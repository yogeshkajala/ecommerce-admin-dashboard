# Api Tester -- Workspace Configuration

## Overview
This workspace includes the **Api Tester** agent. Test API contracts: request/response validation, error handling, pagination, auth.

## Agent Invocation
- Use `@api-tester` to invoke the agent directly
- Use `/api-tester.prompt` for guided workflow prompts
- Use `/api-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `API_TESTER_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `API_TESTER_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `API_TESTER_PARALLEL` | `true` | Run tests in parallel when possible |
| `API_TESTER_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `API_TESTER_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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