# Api Designer -- User Guide

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
|   |   \-- api-designer/
|   |       \-- api-designer.agent.md
|   |-- skills/
|   |   \-- api-designer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- api-designer.instructions.md
|   |-- hooks/
|   |   \-- api-designer-hook.json
|   |-- prompts/
|   |   \-- api-designer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@api-designer <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `api-designer.prompt` for a structured workflow.

---

## Description
Design API contracts: REST endpoints, GraphQL schemas, gRPC protos, and API documentation.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `api-designer.instructions.md`
- Leverages domain knowledge from `api-designer-skill/SKILL.md`
- Can be triggered via hooks defined in `api-designer-hook.json`
