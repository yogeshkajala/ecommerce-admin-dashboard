# Security Scanner -- Workspace Configuration

## Overview
This workspace includes the **Security Scanner** agent. Use when scanning code for security vulnerabilities, dependency CVEs, hardcoded secrets, and OWASP Top 10 compliance.

## Agent Invocation
- Use `@security-scanner` to invoke the agent directly
- Use `/security-scanner.prompt` for guided workflow prompts
- The `security-scanner-skill` skill provides domain knowledge

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
