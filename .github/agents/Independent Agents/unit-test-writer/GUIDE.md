# Unit Test Writer -- User Guide

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
|   |   \-- unit-test-writer/
|   |       \-- unit-test-writer.agent.md
|   |-- skills/
|   |   \-- unit-test-writer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- unit-test-writer.instructions.md
|   |-- hooks/
|   |   \-- unit-test-writer-hook.json
|   |-- prompts/
|   |   \-- unit-test-writer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@unit-test-writer <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `unit-test-writer.prompt` for a structured workflow.

---

## Description
Use when writing unit tests for new feature code including happy path, edge cases, and error handling.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `unit-test-writer.instructions.md`
- Leverages domain knowledge from `unit-test-writer-skill/SKILL.md`
- Can be triggered via hooks defined in `unit-test-writer-hook.json`
