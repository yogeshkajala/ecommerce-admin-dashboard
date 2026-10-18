# E2e Test Creator -- Workspace Configuration

## Overview
This workspace includes the **E2e Test Creator** agent. Use when creating end-to-end tests that verify complete user workflows through the full system stack.

## Agent Invocation
- Use `@e2e-test-creator` to invoke the agent directly
- Use `/e2e-test-creator.prompt` for guided workflow prompts
- Use `/e2e-test-creator-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `E2E_TEST_CRE_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `E2E_TEST_CRE_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `E2E_TEST_CRE_PARALLEL` | `true` | Run tests in parallel when possible |
| `E2E_TEST_CRE_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `E2E_TEST_CRE_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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