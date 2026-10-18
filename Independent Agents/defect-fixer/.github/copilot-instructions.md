# defect fixer.Groups[1].Value.ToUpper()efect defect fixer.Groups[1].Value.ToUpper()ixer -- Workspace Configuration

## Overview
This workspace includes the **defect fixer.Groups[1].Value.ToUpper()efect defect fixer.Groups[1].Value.ToUpper()ixer** agent. Use when performing root cause analysis (5 whys, fault tree), implementing minimal-impact fixes, assessing fix blast radius, or preparing hotfix patches.

## Agent Invocation
- Use `@defect-fixer` to invoke the agent directly
- Use `/defect-fixer.prompt` for guided workflow prompts
- The `defect-fixer-skill` skill provides domain knowledge

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
