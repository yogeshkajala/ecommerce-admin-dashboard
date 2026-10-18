# Security Scanner -- User Guide

## Prerequisites

### Software Requirements
| Requirement | Minimum Version | Purpose |
|-------------|----------------|---------|
| **VS Code** | 1.100+ | IDE with Copilot Chat support |
| **GitHub Copilot Chat extension** | Latest | Agent picker, slash commands, skill loading |
| **GitHub Copilot license** | Active | Required for agent invocation |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- security-scanner/
|   |       \-- security-scanner.agent.md
|   |-- skills/
|   |   \-- security-scanner-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- security-scanner.instructions.md
|   |-- hooks/
|   |   \-- security-scanner-hook.json
|   |-- prompts/
|   |   \-- security-scanner.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@security-scanner <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `security-scanner.prompt` for a structured workflow.

---

## Description
Use when scanning code for security vulnerabilities, dependency CVEs, hardcoded secrets, and OWASP Top 10 compliance.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `security-scanner.instructions.md`
- Leverages domain knowledge from `security-scanner-skill/SKILL.md`
- Can be triggered via hooks defined in `security-scanner-hook.json`
