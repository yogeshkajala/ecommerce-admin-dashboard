# Acceptance Criteria Definer -- User Guide

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
|   |   \-- acceptance-criteria-definer/
|   |       \-- acceptance-criteria-definer.agent.md
|   |-- skills/
|   |   \-- acceptance-criteria-definer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- acceptance-criteria-definer.instructions.md
|   |-- hooks/
|   |   \-- acceptance-criteria-definer-hook.json
|   |-- prompts/
|   |   \-- acceptance-criteria-definer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@acceptance-criteria-definer <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `acceptance-criteria-definer.prompt` for a structured workflow.

---

## Description
Use when defining testable acceptance criteria for user stories using Given/When/Then or equivalent formats.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `acceptance-criteria-definer.instructions.md`
- Leverages domain knowledge from `acceptance-criteria-definer-skill/SKILL.md`
- Can be triggered via hooks defined in `acceptance-criteria-definer-hook.json`
