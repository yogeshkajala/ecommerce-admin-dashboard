# defect triager.Groups[1].Value.ToUpper()efect defect triager.Groups[1].Value.ToUpper()riager -- Workspace Configuration

## Overview
This workspace includes the **defect triager.Groups[1].Value.ToUpper()efect defect triager.Groups[1].Value.ToUpper()riager** agent. Use when triaging defects, assigning severity and priority, determining sla targets, assessing user impact, or classifying defect categories.

## Agent Invocation
- Use `@defect-triager` to invoke the agent directly
- Use `/defect-triager.prompt` for guided workflow prompts
- The `defect-triager-skill` skill provides domain knowledge

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
