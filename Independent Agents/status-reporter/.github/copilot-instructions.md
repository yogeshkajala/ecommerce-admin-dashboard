# Status Reporter -- Workspace Configuration

## Overview
This workspace includes the **Status Reporter** agent. Use when generating project status reports with RAG status, metrics, risks, and next actions.

## Agent Invocation
- Use `@status-reporter` to invoke the agent directly
- Use `/status-reporter.prompt` for guided workflow prompts
- The `status-reporter-skill` skill provides domain knowledge

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
