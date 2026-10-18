# Api Designer -- Workspace Configuration

## Overview
This workspace includes the **Api Designer** agent. Design API contracts: REST endpoints, GraphQL schemas, gRPC protos, and API documentation.

## Agent Invocation
- Use `@api-designer` to invoke the agent directly
- Use `/api-designer.prompt` for guided workflow prompts
- The `api-designer-skill` skill provides domain knowledge

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
