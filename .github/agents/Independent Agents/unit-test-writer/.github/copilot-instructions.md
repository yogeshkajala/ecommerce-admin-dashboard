# Unit Test Writer -- Workspace Configuration

## Overview
This workspace includes the **Unit Test Writer** agent. Use when writing unit tests for new feature code including happy path, edge cases, and error handling.

## Agent Invocation
- Use `@unit-test-writer` to invoke the agent directly
- Use `/unit-test-writer.prompt` for guided workflow prompts
- The `unit-test-writer-skill` skill provides domain knowledge

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
