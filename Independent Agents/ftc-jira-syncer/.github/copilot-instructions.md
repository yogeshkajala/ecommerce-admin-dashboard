# Ftc Jira Syncer -- Workspace Configuration

## Overview
This workspace includes the **Ftc Jira Syncer** agent. Synchronize test cases and results with Jira: create test issues, link to stories, update execution status.

## Agent Invocation
- Use `@ftc-jira-syncer` to invoke the agent directly
- Use `/ftc-jira-syncer.prompt` for guided workflow prompts
- Use `/ftc-jira-syncer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FTC_JIRA_SYN_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FTC_JIRA_SYN_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FTC_JIRA_SYN_PARALLEL` | `true` | Run tests in parallel when possible |
| `FTC_JIRA_SYN_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FTC_JIRA_SYN_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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