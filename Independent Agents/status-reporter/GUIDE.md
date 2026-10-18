# Status Reporter -- User Guide

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
|   |   \-- status-reporter/
|   |       \-- status-reporter.agent.md
|   |-- skills/
|   |   \-- status-reporter-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- status-reporter.instructions.md
|   |-- hooks/
|   |   \-- status-reporter-hook.json
|   |-- prompts/
|   |   \-- status-reporter.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@status-reporter <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `status-reporter.prompt` for a structured workflow.

---

## Description
Use when generating project status reports with RAG status, metrics, risks, and next actions.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `status-reporter.instructions.md`
- Leverages domain knowledge from `status-reporter-skill/SKILL.md`
- Can be triggered via hooks defined in `status-reporter-hook.json`
