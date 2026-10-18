# Acceptance Criteria Definer -- Workspace Configuration

## Overview
This workspace includes the **Acceptance Criteria Definer** agent. Use when defining testable acceptance criteria for user stories using Given/When/Then or equivalent formats.

## Agent Invocation
- Use `@acceptance-criteria-definer` to invoke the agent directly
- Use `/acceptance-criteria-definer.prompt` for guided workflow prompts
- The `acceptance-criteria-definer-skill` skill provides domain knowledge

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
