# Compliance Test Writer -- Workspace Configuration

## Overview
This workspace includes the **Compliance Test Writer** agent. Generate compliance and regulatory tests: audit logging, data retention, access controls, and regulatory checks.

## Agent Invocation
- Use `@compliance-test-writer` to invoke the agent directly
- Use `/compliance-test-writer.prompt` for guided workflow prompts
- Use `/compliance-test-writer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `COMPLIANCE_T_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `COMPLIANCE_T_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `COMPLIANCE_T_PARALLEL` | `true` | Run tests in parallel when possible |
| `COMPLIANCE_T_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `COMPLIANCE_T_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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