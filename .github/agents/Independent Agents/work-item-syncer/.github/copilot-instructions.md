# Work Item Syncer -- Workspace Configuration

## Overview
This workspace includes the **Work Item Syncer** agent. Use when creating Jira issues, syncing work items from requirements documents, or performing bulk ticket operations.

## Agent Invocation
- Use `@work-item-syncer` to invoke the agent directly
- Use `/work-item-syncer.prompt` for guided workflow prompts
- The `work-item-syncer-skill` skill provides domain knowledge

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
