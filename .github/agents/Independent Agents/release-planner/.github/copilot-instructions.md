# Release Planner -- Workspace Configuration

## Overview
This workspace includes the **Release Planner** agent. Plan releases with scope definition, milestones, feature readiness, and go-live criteria.

## Agent Invocation
- Use `@release-planner` to invoke the agent directly
- Use `/release-planner.prompt` for guided workflow prompts
- The `release-planner-skill` skill provides domain knowledge

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
