# Defect Fixer -- Workspace Configuration

## Overview
This workspace includes the **Defect Fixer** agent. Use when performing root cause analysis (5 Whys, fault tree), implementing minimal-impact fixes, assessing fix blast radius, or preparing hotfix patches for defects.

## Agent Invocation
- Use `@defect-fixer` to invoke the agent directly
- Use `/defect-fixer.prompt` for guided workflow prompts
- Use `/defect-fixer-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEFECT_FIXER_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `DEFECT_FIXER_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `DEFECT_FIXER_PARALLEL` | `true` | Run tests in parallel when possible |
| `DEFECT_FIXER_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `DEFECT_FIXER_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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