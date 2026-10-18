# Api Contract Tester -- Workspace Configuration

## Overview
This workspace includes the **Api Contract Tester** agent. Use when testing API contracts against OpenAPI specifications including request/response validation, error codes, and schema compliance.

## Agent Invocation
- Use `@api-contract-tester` to invoke the agent directly
- Use `/api-contract-tester.prompt` for guided workflow prompts
- Use `/api-contract-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `API_CONTRACT_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `API_CONTRACT_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `API_CONTRACT_PARALLEL` | `true` | Run tests in parallel when possible |
| `API_CONTRACT_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `API_CONTRACT_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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