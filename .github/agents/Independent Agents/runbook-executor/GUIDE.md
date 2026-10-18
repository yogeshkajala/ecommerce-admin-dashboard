# Runbook Executor -- User Guide

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
| **Knowledge Base** | Confluence / SharePoint / Wiki API token |
| **Search Platform** | Elasticsearch / Algolia API credentials |
| **Document Store** | S3 / Azure Blob / GCS for document storage |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- runbook-executor/
|   |       \-- runbook-executor.agent.md
|   |-- skills/
|   |   \-- runbook-executor-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- runbook-executor.instructions.md
|   |-- hooks/
|   |   \-- runbook-executor-hook.json
|   |-- prompts/
|   |   \-- runbook-executor.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `RUNBOOK_EXEC_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `RUNBOOK_EXEC_DRY_RUN` | `false` | Preview changes without executing |
| `RUNBOOK_EXEC_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `RUNBOOK_EXEC_TIMEOUT` | `300` | Maximum execution time in seconds |
| `RUNBOOK_EXEC_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@runbook-executor`
4. Type `/` -- you should see `/runbook-executor.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@runbook-executor Create a runbook for the database failover procedure
@runbook-executor Search knowledge base for previous incidents related to memory leaks
@runbook-executor Update the onboarding guide with the new deployment process
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/runbook-executor.prompt` | Guided workflow for Runbook Executor with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@runbook-executor Execute operational runbooks with safety checks, step validation, and rollback capabilities for incident response and maintenance.
```

#### Detailed Request
```
@runbook-executor I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Runbook Executor |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@runbook-executor`) |
| **Domain** | Knowledge |
| **Description** | Execute operational runbooks with safety checks, step validation, and rollback capabilities for incident response and maintenance. |
| **Tools** | read, search, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **runbook-executor-skill** | Knowledge | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Runbook Executor operations |

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
| `runbook-executor-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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