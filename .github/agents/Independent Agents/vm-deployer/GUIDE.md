# Vm Deployer -- User Guide

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
|   |   \-- vm-deployer/
|   |       \-- vm-deployer.agent.md
|   |-- skills/
|   |   \-- vm-deployer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- vm-deployer.instructions.md
|   |-- hooks/
|   |   \-- vm-deployer-hook.json
|   |-- prompts/
|   |   \-- vm-deployer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@vm-deployer <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `vm-deployer.prompt` for a structured workflow.

---

## Description
Use when deploying applications to VMs, managing containers, building Docker images, or performing infrastructure operations.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `vm-deployer.instructions.md`
- Leverages domain knowledge from `vm-deployer-skill/SKILL.md`
- Can be triggered via hooks defined in `vm-deployer-hook.json`
