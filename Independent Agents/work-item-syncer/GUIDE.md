# Work Item Syncer -- User Guide

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
|   |   \-- work-item-syncer/
|   |       \-- work-item-syncer.agent.md
|   |-- skills/
|   |   \-- work-item-syncer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- work-item-syncer.instructions.md
|   |-- hooks/
|   |   \-- work-item-syncer-hook.json
|   |-- prompts/
|   |   \-- work-item-syncer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@work-item-syncer <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `work-item-syncer.prompt` for a structured workflow.

---

## Description
Use when creating Jira issues, syncing work items from requirements documents, or performing bulk ticket operations.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `work-item-syncer.instructions.md`
- Leverages domain knowledge from `work-item-syncer-skill/SKILL.md`
- Can be triggered via hooks defined in `work-item-syncer-hook.json`
