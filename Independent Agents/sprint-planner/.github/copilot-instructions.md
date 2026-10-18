# Sprint Planner -- Workspace Configuration

## Overview
This workspace includes the **Sprint Planner** agent. Use when planning sprints, scoping sprint work, analyzing team capacity, managing sprint backlogs, or forecasting delivery dates in Jira.

## Agent Invocation
- Use `@sprint-planner` to invoke the agent directly
- Use `/sprint-planner.prompt` for guided workflow prompts
- The `sprint-planner-skill` skill provides domain knowledge

## Key Conventions
- Follow established coding standards and best practices
- Use the agent for domain-specific tasks within its scope
- Provide clear, specific context when invoking the agent
- Review agent outputs before applying changes

## Safety Guardrails
- All inputs are validated before processing
- Outputs are checked for accuracy and completeness
- Prompt injection patterns are detected and blocked
- Sensitive data is never included in agent outputs
- Human approval required for destructive operations
