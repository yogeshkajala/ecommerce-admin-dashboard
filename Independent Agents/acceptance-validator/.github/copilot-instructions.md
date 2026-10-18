# Acceptance Validator -- Workspace Configuration

## Overview
This workspace includes the **Acceptance Validator** agent. Use when verifying that implemented features meet all acceptance criteria defined during requirements.

## Agent Invocation
- Use `@acceptance-validator` to invoke the agent directly
- Use `/acceptance-validator.prompt` for guided workflow prompts
- The `acceptance-validator-skill` skill provides domain knowledge

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
