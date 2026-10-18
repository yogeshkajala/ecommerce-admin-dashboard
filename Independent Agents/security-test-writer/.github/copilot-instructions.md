# Security Test Writer -- Workspace Configuration

## Overview
This workspace includes the **Security Test Writer** agent. Generate security tests: OWASP Top 10 checks, authentication bypass, injection, and authorization tests.

## Agent Invocation
- Use `@security-test-writer` to invoke the agent directly
- Use `/security-test-writer.prompt` for guided workflow prompts
- Use `/security-test-writer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `SECURITY_TES_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `SECURITY_TES_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `SECURITY_TES_PARALLEL` | `true` | Run tests in parallel when possible |
| `SECURITY_TES_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `SECURITY_TES_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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