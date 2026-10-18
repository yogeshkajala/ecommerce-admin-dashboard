# defect fixer.Groups[1].Value.ToUpper()efect defect fixer.Groups[1].Value.ToUpper()ixer -- User Guide

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
```n
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- defect-fixer/
|   |       \-- defect-fixer.agent.md
|   |-- skills/
|   |   \-- defect-fixer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- defect-fixer.instructions.md
|   |-- hooks/
|   |   \-- defect-fixer-hook.json
|   |-- prompts/
|   |   \-- defect-fixer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```n
### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```n@defect-fixer <your request>
```n
### Step 3 -- Use Guided Prompts
Type `/` in chat and select `defect-fixer.prompt` for a structured workflow.

---

## Description
Performing root cause analysis (5 Whys, fault tree), implementing minimal-impact fixes, assessing fix blast radius, or preparing hotfix patches.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `defect-fixer.instructions.md`
- Leverages domain knowledge from `defect-fixer-skill/SKILL.md`
- Can be triggered via hooks defined in `defect-fixer-hook.json`
