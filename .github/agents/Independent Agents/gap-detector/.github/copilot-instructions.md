# Gap Detector -- Workspace Configuration

## Overview
This workspace includes the **Gap Detector** agent. Use when analyzing requirement specifications to identify gaps, ambiguities, contradictions, missing edge cases, and incomplete coverage.

## Agent Invocation
- Use `@gap-detector` to invoke the agent directly
- Use `/gap-detector.prompt` for guided workflow prompts
- Use `/gap-detector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `GAP_DETECTOR_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `GAP_DETECTOR_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `GAP_DETECTOR_PARALLEL` | `true` | Run tests in parallel when possible |
| `GAP_DETECTOR_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `GAP_DETECTOR_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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