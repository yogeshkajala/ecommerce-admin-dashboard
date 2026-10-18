# Codebase Profiler -- Workspace Configuration

## Overview
This workspace includes the **Codebase Profiler** agent. Use when profiling a codebase for tech stack detection, test coverage analysis, CI/CD pipeline inventory, database technology mapping, or generating a repository health overview.

## Agent Invocation
- Use `@codebase-profiler` to invoke the agent directly
- Use `/codebase-profiler.prompt` for guided workflow prompts
- Use `/codebase-profiler-skill` skill for domain knowledge

## Configuration
Customize agent behavior by modifying these settings:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODEBASE_PRO_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `CODEBASE_PRO_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `CODEBASE_PRO_PARALLEL` | `true` | Run tests in parallel when possible |
| `CODEBASE_PRO_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `CODEBASE_PRO_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

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