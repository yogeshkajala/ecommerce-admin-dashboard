# Code Reviewer -- User Guide

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
|   |   \-- code-reviewer/
|   |       \-- code-reviewer.agent.md
|   |-- skills/
|   |   \-- code-reviewer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- code-reviewer.instructions.md
|   |-- hooks/
|   |   \-- code-reviewer-hook.json
|   |-- prompts/
|   |   \-- code-reviewer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Invoke the Agent
Open GitHub Copilot Chat and type:
```
@code-reviewer <your request>
```

### Step 3 -- Use Guided Prompts
Type `/` in chat and select `code-reviewer.prompt` for a structured workflow.

---

## Description
Use when reviewing code for correctness, security vulnerabilities (OWASP Top 10), performance anti-patterns, and coding standards compliance.

## What This Agent Does
- Executes its specialized workflow when invoked
- Follows instructions defined in `code-reviewer.instructions.md`
- Leverages domain knowledge from `code-reviewer-skill/SKILL.md`
- Can be triggered via hooks defined in `code-reviewer-hook.json`
