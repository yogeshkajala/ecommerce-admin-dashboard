# Risk Assessor -- User Guide

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
|   |   \-- risk-assessor/
|   |       \-- risk-assessor.agent.md
|   |-- skills/
|   |   \-- risk-assessor-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- risk-assessor.instructions.md
|   |-- hooks/
|   |   \-- risk-assessor-hook.json
|   |-- prompts/
|   |   \-- risk-assessor.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@risk-assessor <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `risk-assessor.prompt` for a structured workflow.

---

## Description
Use when assessing identified project risks for impact, likelihood, and priority ranking.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `risk-assessor.instructions.md`
- Leverages domain knowledge from `risk-assessor-skill/SKILL.md`
- Can be triggered via hooks defined in `risk-assessor-hook.json`
