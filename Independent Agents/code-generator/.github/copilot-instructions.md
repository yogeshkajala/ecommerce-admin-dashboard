# Code Generator -- Workspace Configuration

## Overview
This workspace includes the **Code Generator** agent. Use when generating production-quality code following project conventions, architecture specifications, and SOLID principles.

## Agent Invocation
- Use `@code-generator` to invoke the agent directly
- Use `/code-generator.prompt` for guided workflow prompts
- The `code-generator-skill` skill provides domain knowledge

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
