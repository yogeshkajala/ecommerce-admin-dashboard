# Defect Detector -- Workspace Configuration

## Overview
This workspace includes the **Defect Detector** agent. Use when detecting defects from test failures, log analysis, monitoring alerts, user reports, or code scanning -- collecting evidence and reproduction steps.

## Agent Invocation
- Use `@defect-detector` to invoke the agent directly
- Use `/defect-detector.prompt` for guided workflow prompts
- Use `/defect-detector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEFECT_DETEC_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `DEFECT_DETEC_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `DEFECT_DETEC_PARALLEL` | `true` | Run tests in parallel when possible |
| `DEFECT_DETEC_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `DEFECT_DETEC_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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