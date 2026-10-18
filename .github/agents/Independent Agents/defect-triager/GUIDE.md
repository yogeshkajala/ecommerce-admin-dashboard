# defect triager.Groups[1].Value.ToUpper()efect defect triager.Groups[1].Value.ToUpper()riager -- User Guide

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
|   |   \-- defect-triager/
|   |       \-- defect-triager.agent.md
|   |-- skills/
|   |   \-- defect-triager-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- defect-triager.instructions.md
|   |-- hooks/
|   |   \-- defect-triager-hook.json
|   |-- prompts/
|   |   \-- defect-triager.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```n
### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```n@defect-triager <your request>
```n
### Step 3 -- Use Guided Prompts
Type `/` in chat and select `defect-triager.prompt` for a structured workflow.

---

## Description
Triaging defects, assigning severity and priority, determining SLA targets, assessing user impact, or classifying defect categories.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `defect-triager.instructions.md`
- Leverages domain knowledge from `defect-triager-skill/SKILL.md`
- Can be triggered via hooks defined in `defect-triager-hook.json`
