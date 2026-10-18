# Codebase Scanner -- User Guide

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
|   |   \-- codebase-scanner/
|   |       \-- codebase-scanner.agent.md
|   |-- skills/
|   |   \-- codebase-scanner-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- codebase-scanner.instructions.md
|   |-- hooks/
|   |   \-- codebase-scanner-hook.json
|   |-- prompts/
|   |   \-- codebase-scanner.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@codebase-scanner <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `codebase-scanner.prompt` for a structured workflow.

---

## Description
Use when scanning codebases to identify files, functions, and modules affected by a proposed feature change.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `codebase-scanner.instructions.md`
- Leverages domain knowledge from `codebase-scanner-skill/SKILL.md`
- Can be triggered via hooks defined in `codebase-scanner-hook.json`
