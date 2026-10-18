# Data Modeler -- Workspace Configuration

## Overview
This workspace includes the **Data Modeler** agent. Design data models: ERDs, domain models, data dictionaries, and relationship mapping.

## Agent Invocation
- Use `@data-modeler` to invoke the agent directly
- Use `/data-modeler.prompt` for guided workflow prompts
- The `data-modeler-skill` skill provides domain knowledge

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
