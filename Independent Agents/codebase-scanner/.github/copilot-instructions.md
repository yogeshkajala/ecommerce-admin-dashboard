# Codebase Scanner -- Workspace Configuration

## Overview
This workspace includes the **Codebase Scanner** agent. Use when scanning codebases to identify files, functions, and modules affected by a proposed feature change.

## Agent Invocation
- Use `@codebase-scanner` to invoke the agent directly
- Use `/codebase-scanner.prompt` for guided workflow prompts
- The `codebase-scanner-skill` skill provides domain knowledge

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
