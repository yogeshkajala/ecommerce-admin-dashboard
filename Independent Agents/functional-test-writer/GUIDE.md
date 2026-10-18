# Functional Test Writer -- User Guide

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
|   |   \-- functional-test-writer/
|   |       \-- functional-test-writer.agent.md
|   |-- skills/
|   |   \-- functional-test-writer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- functional-test-writer.instructions.md
|   |-- hooks/
|   |   \-- functional-test-writer-hook.json
|   |-- prompts/
|   |   \-- functional-test-writer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@functional-test-writer <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `functional-test-writer.prompt` for a structured workflow.

---

## Description
Generate functional and integration tests: E2E scenarios, BDD features, API tests, and acceptance criteria validation.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `functional-test-writer.instructions.md`
- Leverages domain knowledge from `functional-test-writer-skill/SKILL.md`
- Can be triggered via hooks defined in `functional-test-writer-hook.json`
