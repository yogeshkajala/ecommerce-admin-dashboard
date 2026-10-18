# root cause analyzer.Groups[1].Value.ToUpper()oot root cause analyzer.Groups[1].Value.ToUpper()ause root cause analyzer.Groups[1].Value.ToUpper()nalyzer -- Workspace Configuration

## Overview
This workspace includes the **root cause analyzer.Groups[1].Value.ToUpper()oot root cause analyzer.Groups[1].Value.ToUpper()ause root cause analyzer.Groups[1].Value.ToUpper()nalyzer** agent. Use when performing root cause analysis on resolved incidents, building incident timelines, or generating preventive action items.

## Agent Invocation
- Use `@root-cause-analyzer` to invoke the agent directly
- Use `/root-cause-analyzer.prompt` for guided workflow prompts
- The `root-cause-analyzer-skill` skill provides domain knowledge

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
