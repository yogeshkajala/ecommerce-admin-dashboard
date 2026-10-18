# Qa Automation Worker -- Workspace Configuration

## Overview
This workspace includes the **Qa Automation Worker** agent. Automated testing of migrated components: regression, smoke, functional, and UAT test execution.

## Agent Invocation
- Use `@qa-automation-worker` to invoke the agent directly
- Use `/qa-automation-worker.prompt` for guided workflow prompts
- Use `/qa-automation-worker-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `QA_AUTOMATIO_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `QA_AUTOMATIO_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `QA_AUTOMATIO_PARALLEL` | `true` | Run tests in parallel when possible |
| `QA_AUTOMATIO_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `QA_AUTOMATIO_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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