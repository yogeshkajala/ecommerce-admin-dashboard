# Effort Estimator -- Workspace Configuration

## Overview
This workspace includes the **Effort Estimator** agent. Use when producing effort estimates with confidence intervals based on scope, complexity, and risk factors.

## Agent Invocation
- Use `@effort-estimator` to invoke the agent directly
- Use `/effort-estimator.prompt` for guided workflow prompts
- The `effort-estimator-skill` skill provides domain knowledge

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
