# Functional Equivalence Tester -- Workspace Configuration

## Overview
This workspace includes the **Functional Equivalence Tester** agent. Use when testing that modern system produces identical results to legacy system for all functional scenarios.

## Agent Invocation
- Use `@functional-equivalence-tester` to invoke the agent directly
- Use `/functional-equivalence-tester.prompt` for guided workflow prompts
- Use `/functional-equivalence-tester-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `FUNCTIONAL_E_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `FUNCTIONAL_E_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `FUNCTIONAL_E_PARALLEL` | `true` | Run tests in parallel when possible |
| `FUNCTIONAL_E_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `FUNCTIONAL_E_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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