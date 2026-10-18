# Code Reviewer -- Workspace Configuration

## Overview
This workspace includes the **Code Reviewer** agent. Use when reviewing code for correctness, security vulnerabilities (OWASP Top 10), performance anti-patterns, and coding standards compliance.

## Agent Invocation
- Use `@code-reviewer` to invoke the agent directly
- Use `/code-reviewer.prompt` for guided workflow prompts
- The `code-reviewer-skill` skill provides domain knowledge

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
