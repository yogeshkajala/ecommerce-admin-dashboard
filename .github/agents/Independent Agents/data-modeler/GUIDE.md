# Data Modeler -- User Guide

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
|   |   \-- data-modeler/
|   |       \-- data-modeler.agent.md
|   |-- skills/
|   |   \-- data-modeler-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- data-modeler.instructions.md
|   |-- hooks/
|   |   \-- data-modeler-hook.json
|   |-- prompts/
|   |   \-- data-modeler.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@data-modeler <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `data-modeler.prompt` for a structured workflow.

---

## Description
Design data models: ERDs, domain models, data dictionaries, and relationship mapping.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `data-modeler.instructions.md`
- Leverages domain knowledge from `data-modeler-skill/SKILL.md`
- Can be triggered via hooks defined in `data-modeler-hook.json`
