# Defect Lifecycle Manager -- Workspace Configuration

## Overview
This workspace includes the **Defect Lifecycle Manager** agent. Use when managing the full defect lifecycle: detection, triage, root cause analysis, fix implementation, validation, and regression testing with severity-based SLAs.

## Agent Invocation
- Use `@defect-lifecycle-manager` to invoke the agent directly
- Use `/defect-lifecycle-manager.prompt` for guided workflow prompts
- Use `/defect-lifecycle-manager-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEFECT_LIFEC_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `DEFECT_LIFEC_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `DEFECT_LIFEC_PARALLEL` | `true` | Run tests in parallel when possible |
| `DEFECT_LIFEC_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `DEFECT_LIFEC_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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