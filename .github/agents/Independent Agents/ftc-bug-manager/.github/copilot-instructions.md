# Ftc Bug Manager -- Workspace Configuration

## Overview
This workspace includes the **Ftc Bug Manager** agent. Manage bug lifecycle: raise bugs from test failures, track fixes, and validate resolutions.

## Agent Invocation
- Use `@ftc-bug-manager` to invoke the agent directly
- Use `/ftc-bug-manager.prompt` for guided workflow prompts
- Use `/ftc-bug-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FTC_BUG_MANA_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FTC_BUG_MANA_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FTC_BUG_MANA_PARALLEL` | `true` | Run tests in parallel when possible |
| `FTC_BUG_MANA_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FTC_BUG_MANA_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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