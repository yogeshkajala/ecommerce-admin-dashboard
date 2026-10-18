# Risk Assessor -- Workspace Configuration

## Overview
This workspace includes the **Risk Assessor** agent. Use when assessing identified project risks for impact, likelihood, and priority ranking.

## Agent Invocation
- Use `@risk-assessor` to invoke the agent directly
- Use `/risk-assessor.prompt` for guided workflow prompts
- The `risk-assessor-skill` skill provides domain knowledge

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
