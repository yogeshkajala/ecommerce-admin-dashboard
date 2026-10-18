# root cause analyzer.Groups[1].Value.ToUpper()oot root cause analyzer.Groups[1].Value.ToUpper()ause root cause analyzer.Groups[1].Value.ToUpper()nalyzer -- User Guide

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
```n
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- root-cause-analyzer/
|   |       \-- root-cause-analyzer.agent.md
|   |-- skills/
|   |   \-- root-cause-analyzer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- root-cause-analyzer.instructions.md
|   |-- hooks/
|   |   \-- root-cause-analyzer-hook.json
|   |-- prompts/
|   |   \-- root-cause-analyzer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```n
### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```n@root-cause-analyzer <your request>
```n
### Step 3 -- Use Guided Prompts
Type `/` in chat and select `root-cause-analyzer.prompt` for a structured workflow.

---

## Description
Performing root cause analysis on resolved incidents, building incident timelines, or generating preventive action items.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `root-cause-analyzer.instructions.md`
- Leverages domain knowledge from `root-cause-analyzer-skill/SKILL.md`
- Can be triggered via hooks defined in `root-cause-analyzer-hook.json`
