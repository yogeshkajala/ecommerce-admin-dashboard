# Functional Test Writer -- Workspace Configuration

## Overview
This workspace includes the **Functional Test Writer** agent. Generate functional and integration tests: E2E scenarios, BDD features, API tests, and acceptance criteria validation.

## Agent Invocation
- Use `@functional-test-writer` to invoke the agent directly
- Use `/functional-test-writer.prompt` for guided workflow prompts
- The `functional-test-writer-skill` skill provides domain knowledge

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
