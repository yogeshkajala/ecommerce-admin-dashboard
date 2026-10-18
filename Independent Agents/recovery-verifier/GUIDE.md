# Recovery Verifier -- User Guide

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
|   |   \-- recovery-verifier/
|   |       \-- recovery-verifier.agent.md
|   |-- skills/
|   |   \-- recovery-verifier-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- recovery-verifier.instructions.md
|   |-- hooks/
|   |   \-- recovery-verifier-hook.json
|   |-- prompts/
|   |   \-- recovery-verifier.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `RECOVERY_VER_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `RECOVERY_VER_DRY_RUN` | `false` | Preview changes without executing |
| `RECOVERY_VER_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `RECOVERY_VER_TIMEOUT` | `300` | Maximum execution time in seconds |
| `RECOVERY_VER_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@recovery-verifier`
4. Type `/` -- you should see `/recovery-verifier.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@recovery-verifier Analyze and provide recommendations for the target system
@recovery-verifier Execute the standard workflow with validation checkpoints
@recovery-verifier Generate a comprehensive report with findings and action items
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/recovery-verifier.prompt` | Guided workflow for Recovery Verifier with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@recovery-verifier Verify system recovery after remediation by checking health endpoints, comparing metrics against baselines, and confirming symptom resolution.
```

#### Detailed Request
```
@recovery-verifier I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Recovery Verifier |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@recovery-verifier`) |
| **Domain** | Ai Safety |
| **Description** | Verify system recovery after remediation by checking health endpoints, comparing metrics against baselines, and confirming symptom resolution. |
| **Tools** | read, search, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **recovery-verifier-skill** | Ai Safety | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Recovery Verifier operations |

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
| `recovery-verifier-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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