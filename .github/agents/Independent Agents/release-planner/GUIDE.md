# Release Planner -- User Guide

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
|   |   \-- release-planner/
|   |       \-- release-planner.agent.md
|   |-- skills/
|   |   \-- release-planner-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- release-planner.instructions.md
|   |-- hooks/
|   |   \-- release-planner-hook.json
|   |-- prompts/
|   |   \-- release-planner.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@release-planner <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `release-planner.prompt` for a structured workflow.

---

## Description
Plan releases with scope definition, milestones, feature readiness, and go-live criteria.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `release-planner.instructions.md`
- Leverages domain knowledge from `release-planner-skill/SKILL.md`
- Can be triggered via hooks defined in `release-planner-hook.json`
