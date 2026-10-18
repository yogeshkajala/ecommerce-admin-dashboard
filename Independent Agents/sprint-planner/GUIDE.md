# Sprint Planner -- User Guide

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
|   |   \-- sprint-planner/
|   |       \-- sprint-planner.agent.md
|   |-- skills/
|   |   \-- sprint-planner-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- sprint-planner.instructions.md
|   |-- hooks/
|   |   \-- sprint-planner-hook.json
|   |-- prompts/
|   |   \-- sprint-planner.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@sprint-planner <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `sprint-planner.prompt` for a structured workflow.

---

## Description
Use when planning sprints, scoping sprint work, analyzing team capacity, managing sprint backlogs, or forecasting delivery dates in Jira.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `sprint-planner.instructions.md`
- Leverages domain knowledge from `sprint-planner-skill/SKILL.md`
- Can be triggered via hooks defined in `sprint-planner-hook.json`
