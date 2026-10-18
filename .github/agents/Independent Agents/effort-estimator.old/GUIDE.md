# Effort Estimator -- User Guide

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
|   |   \-- effort-estimator/
|   |       \-- effort-estimator.agent.md
|   |-- skills/
|   |   \-- effort-estimator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- effort-estimator.instructions.md
|   |-- hooks/
|   |   \-- effort-estimator-hook.json
|   |-- prompts/
|   |   \-- effort-estimator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `EFFORT_ESTIM_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `EFFORT_ESTIM_DRY_RUN` | `false` | Preview changes without executing |
| `EFFORT_ESTIM_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `EFFORT_ESTIM_TIMEOUT` | `300` | Maximum execution time in seconds |
| `EFFORT_ESTIM_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@effort-estimator`
4. Type `/` -- you should see `/effort-estimator.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@effort-estimator Extract functional requirements from the PRD document
@effort-estimator Generate acceptance criteria for the user authentication epic
@effort-estimator Analyze requirement dependencies and identify gaps
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/effort-estimator.prompt` | Guided workflow for Effort Estimator with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@effort-estimator Use when producing effort estimates with confidence intervals based on scope, complexity, and risk factors.
```

#### Detailed Request
```
@effort-estimator I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Effort Estimator |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@effort-estimator`) |
| **Domain** | Requirements |
| **Description** | Use when producing effort estimates with confidence intervals based on scope, complexity, and risk factors. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **effort-estimator-skill** | Requirements | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Effort Estimator operations |

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
| `effort-estimator-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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