# Code Generator -- User Guide

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
|   |   \-- code-generator/
|   |       \-- code-generator.agent.md
|   |-- skills/
|   |   \-- code-generator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- code-generator.instructions.md
|   |-- hooks/
|   |   \-- code-generator-hook.json
|   |-- prompts/
|   |   \-- code-generator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@code-generator <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `code-generator.prompt` for a structured workflow.

---

## Description
Use when generating production-quality code following project conventions, architecture specifications, and SOLID principles.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `code-generator.instructions.md`
- Leverages domain knowledge from `code-generator-skill/SKILL.md`
- Can be triggered via hooks defined in `code-generator-hook.json`
