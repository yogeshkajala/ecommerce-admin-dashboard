# Effort Estimator -- User Guide

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
|   |   \-- effort-estimator/
|   |       \-- effort-estimator.agent.md
|   |-- skills/
|   |   \-- effort-estimator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- effort-estimator.instructions.md
|   |-- hooks/
|   |   \-- effort-estimator-hook.json
|   |-- prompts/
|   |   \-- effort-estimator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@effort-estimator <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `effort-estimator.prompt` for a structured workflow.

---

## Description
Use when producing effort estimates with confidence intervals based on scope, complexity, and risk factors.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `effort-estimator.instructions.md`
- Leverages domain knowledge from `effort-estimator-skill/SKILL.md`
- Can be triggered via hooks defined in `effort-estimator-hook.json`
