# Acceptance Validator -- User Guide

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
|   |   \-- acceptance-validator/
|   |       \-- acceptance-validator.agent.md
|   |-- skills/
|   |   \-- acceptance-validator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- acceptance-validator.instructions.md
|   |-- hooks/
|   |   \-- acceptance-validator-hook.json
|   |-- prompts/
|   |   \-- acceptance-validator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@acceptance-validator <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `acceptance-validator.prompt` for a structured workflow.

---

## Description
Use when verifying that implemented features meet all acceptance criteria defined during requirements.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `acceptance-validator.instructions.md`
- Leverages domain knowledge from `acceptance-validator-skill/SKILL.md`
- Can be triggered via hooks defined in `acceptance-validator-hook.json`
