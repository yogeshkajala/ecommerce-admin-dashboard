# Vm Deployer -- Workspace Configuration

## Overview
This workspace includes the **Vm Deployer** agent. Use when deploying applications to VMs, managing containers, building Docker images, or performing infrastructure operations.

## Agent Invocation
- Use `@vm-deployer` to invoke the agent directly
- Use `/vm-deployer.prompt` for guided workflow prompts
- The `vm-deployer-skill` skill provides domain knowledge

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
