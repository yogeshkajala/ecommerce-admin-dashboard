# Evidence Grounder -- User Guide

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
| **Monitoring Platform** | Datadog / Grafana / Prometheus API key |
| **ITSM** | ServiceNow / Jira Service Management API token |
| **Communication** | Slack / Microsoft Teams webhook URL |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- evidence-grounder/
|   |       \-- evidence-grounder.agent.md
|   |-- skills/
|   |   \-- evidence-grounder-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- evidence-grounder.instructions.md
|   |-- hooks/
|   |   \-- evidence-grounder-hook.json
|   |-- prompts/
|   |   \-- evidence-grounder.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `EVIDENCE_GRO_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `EVIDENCE_GRO_DRY_RUN` | `false` | Preview changes without executing |
| `EVIDENCE_GRO_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `EVIDENCE_GRO_TIMEOUT` | `300` | Maximum execution time in seconds |
| `EVIDENCE_GRO_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@evidence-grounder`
4. Type `/` -- you should see `/evidence-grounder.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@evidence-grounder Analyze and provide recommendations for the target system
@evidence-grounder Execute the standard workflow with validation checkpoints
@evidence-grounder Generate a comprehensive report with findings and action items
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/evidence-grounder.prompt` | Guided workflow for Evidence Grounder with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@evidence-grounder Use when ensuring AI outputs are grounded in retrievable evidence, adding citations to claims, mapping assertions to source documents, or detecting ungrounded statements.
```

#### Detailed Request
```
@evidence-grounder I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Evidence Grounder |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@evidence-grounder`) |
| **Domain** | Ai Safety |
| **Description** | Use when ensuring AI outputs are grounded in retrievable evidence, adding citations to claims, mapping assertions to source documents, or detecting ungrounded statements. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **evidence-grounder-skill** | Ai Safety | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Evidence Grounder operations |

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
| `evidence-grounder-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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