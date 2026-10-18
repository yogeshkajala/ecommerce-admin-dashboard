# Test Automation Lead -- Workspace Configuration

## Overview
This workspace includes the **Test Automation Lead** agent. Use when building and maintaining test automation -- frameworks, CI integration, test data management, and flaky test resolution.

## Agent Invocation
- Use `@test-automation-lead` to invoke the agent directly
- Use `/test-automation-lead.prompt` for guided workflow prompts
- Use `/test-automation-lead-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TEST_AUTOMAT_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TEST_AUTOMAT_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TEST_AUTOMAT_PARALLEL` | `true` | Run tests in parallel when possible |
| `TEST_AUTOMAT_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TEST_AUTOMAT_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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