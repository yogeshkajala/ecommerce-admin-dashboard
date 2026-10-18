# Feature Requirements Analyst -- User Guide

## Prerequisites

### Software Requirements
| Requirement | Minimum Version | Purpose |
|-------------|----------------|---------|
| **VS Code** | 1.100+ | IDE with Copilot Chat support |
| **GitHub Copilot Chat extension** | Latest | Agent picker, slash commands, skill loading |
| **GitHub Copilot license** | Active | Required for agent invocation |

### Connector Credentials (Optional)
Configure only the connectors you use. Each connector requires credentials in `.vscode/mcp.json`:

| Connector | Credentials Needed |
|-----------|-------------------|
| **GitHub** | Personal Access Token (PAT) with repo scope |
| **Requirements Tool** | Jira / Azure Boards / Aha! API token |
| **Document Platform** | Confluence / SharePoint API for requirements docs |
| **Communication** | Slack / Teams webhook for stakeholder notifications |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- feature-requirements-analyst/
|   |       \-- feature-requirements-analyst.agent.md
|   |-- skills/
|   |   \-- feature-requirements-analyst-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- feature-requirements-analyst.instructions.md
|   |-- hooks/
|   |   \-- feature-requirements-analyst-hook.json
|   |-- prompts/
|   |   \-- feature-requirements-analyst.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `FEATURE_REQU_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `FEATURE_REQU_DRY_RUN` | `false` | Preview changes without executing |
| `FEATURE_REQU_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `FEATURE_REQU_TIMEOUT` | `300` | Maximum execution time in seconds |
| `FEATURE_REQU_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@feature-requirements-analyst`
4. Type `/` -- you should see `/feature-requirements-analyst.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@feature-requirements-analyst Extract functional requirements from the PRD document
@feature-requirements-analyst Generate acceptance criteria for the user authentication epic
@feature-requirements-analyst Analyze requirement dependencies and identify gaps
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/feature-requirements-analyst.prompt` | Guided workflow for Feature Requirements Analyst with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@feature-requirements-analyst Use when gathering and documenting feature requirements from stakeholders, user stories, acceptance criteria, and dependency analysis.
```

#### Detailed Request
```
@feature-requirements-analyst I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Feature Requirements Analyst |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@feature-requirements-analyst`) |
| **Domain** | Requirements |
| **Description** | Use when gathering and documenting feature requirements from stakeholders, user stories, acceptance criteria, and dependency analysis. |
| **Tools** | read, search, agent, edit, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **feature-requirements-analyst-skill** | Requirements | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Feature Requirements Analyst operations |

---

## Features

### Agent Architecture
| Level | Role | Count |
|-------|------|------:|
| L1 | Specialist Agent | 1 |
| **Total** | | **1** |

### Automated Hook Protection
Pre-built hooks that activate automatically:

| Hook | Event | What It Does |
|------|-------|-------------|
| `feature-requirements-analyst-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

### Operational Maturity Model
| Level | Name | Characteristics | Target |
|-------|------|----------------|--------|
| **L1** | Reactive | Manual processes, ad-hoc responses | Baseline |
| **L2** | Defined | Documented procedures, basic automation | 6 months |
| **L3** | Measured | Metrics-driven, SLO tracking | 12 months |
| **L4** | Managed | Predictive analytics, proactive actions | 18 months |
| **L5** | Optimized | Self-healing, continuous improvement | 24 months |

### Integration Points
| System | Integration | Purpose |
|--------|-----------|---------|
| **GitHub** | API + Webhooks | Source control, PR automation |
| **CI/CD** | Pipeline triggers | Build and deployment automation |
| **Monitoring** | Metrics + Alerts | Operational visibility |
| **ITSM** | Ticket API | Change and incident management |

### Industry Standards Built In
| Standard | Applied To |
|----------|-----------|
| **ITIL v4** | Service management best practices |
| **ISO 20000** | IT service management standard |
| **COBIT** | IT governance and management framework |
| **TOGAF** | Enterprise architecture methodology |
| **SAFe** | Scaled agile framework for enterprise |