# Tool Selector -- Workspace Configuration

## Overview
This workspace includes the **Tool Selector** agent. Select testing tools and frameworks based on technology stack and requirements.

## Agent Invocation
- Use `@tool-selector` to invoke the agent directly
- Use `/tool-selector.prompt` for guided workflow prompts
- Use `/tool-selector-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `TOOL_SELECTO_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `TOOL_SELECTO_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `TOOL_SELECTO_PARALLEL` | `true` | Run tests in parallel when possible |
| `TOOL_SELECTO_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `TOOL_SELECTO_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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