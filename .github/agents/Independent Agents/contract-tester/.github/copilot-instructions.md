# Contract Tester -- Workspace Configuration

## Overview
This workspace includes the **Contract Tester** agent. Use when running consumer-driven contract tests between microservices to verify API and event contract compliance.

## Agent Invocation
- Use `@contract-tester` to invoke the agent directly
- Use `/contract-tester.prompt` for guided workflow prompts
- Use `/contract-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CONTRACT_TES_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `CONTRACT_TES_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `CONTRACT_TES_PARALLEL` | `true` | Run tests in parallel when possible |
| `CONTRACT_TES_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `CONTRACT_TES_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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