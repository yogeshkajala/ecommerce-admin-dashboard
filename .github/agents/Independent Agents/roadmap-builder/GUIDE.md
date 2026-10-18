# Roadmap Builder -- User Guide

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
| **Project Tool** | Jira / Azure Boards / Trello API token |
| **Communication** | Slack / Microsoft Teams webhook URL |
| **Reporting** | Power BI / Tableau / custom dashboard API |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- roadmap-builder/
|   |       \-- roadmap-builder.agent.md
|   |-- skills/
|   |   \-- roadmap-builder-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- roadmap-builder.instructions.md
|   |-- hooks/
|   |   \-- roadmap-builder-hook.json
|   |-- prompts/
|   |   \-- roadmap-builder.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `ROADMAP_BUIL_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `ROADMAP_BUIL_DRY_RUN` | `false` | Preview changes without executing |
| `ROADMAP_BUIL_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `ROADMAP_BUIL_TIMEOUT` | `300` | Maximum execution time in seconds |
| `ROADMAP_BUIL_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@roadmap-builder`
4. Type `/` -- you should see `/roadmap-builder.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@roadmap-builder Generate sprint report for Sprint 24 with velocity metrics
@roadmap-builder Analyze backlog health and recommend prioritization adjustments
@roadmap-builder Create release plan for version 3.0 with dependency mapping
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/roadmap-builder.prompt` | Guided workflow for Roadmap Builder with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@roadmap-builder Build phased migration roadmap with waves, dependencies, milestones, and resource allocation.
```

#### Detailed Request
```
@roadmap-builder I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Roadmap Builder |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@roadmap-builder`) |
| **Domain** | Project |
| **Description** | Build phased migration roadmap with waves, dependencies, milestones, and resource allocation. |
| **Tools** | read, search, editFiles |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **roadmap-builder-skill** | Project | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Roadmap Builder operations |

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
| `roadmap-builder-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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