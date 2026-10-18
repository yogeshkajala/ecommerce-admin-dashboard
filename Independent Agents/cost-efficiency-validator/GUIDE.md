# Cost Efficiency Validator -- User Guide

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
| **Cloud Billing** | AWS Cost Explorer / Azure Cost Management / GCP Billing API credentials |
| **FinOps Platform** | CloudHealth / Spot.io / Kubecost API token |
| **Budgeting Tool** | Budget tracking API credentials |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- cost-efficiency-validator/
|   |       \-- cost-efficiency-validator.agent.md
|   |-- skills/
|   |   \-- cost-efficiency-validator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- cost-efficiency-validator.instructions.md
|   |-- hooks/
|   |   \-- cost-efficiency-validator-hook.json
|   |-- prompts/
|   |   \-- cost-efficiency-validator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `COST_EFFICIE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `COST_EFFICIE_DRY_RUN` | `false` | Preview changes without executing |
| `COST_EFFICIE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `COST_EFFICIE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `COST_EFFICIE_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@cost-efficiency-validator`
4. Type `/` -- you should see `/cost-efficiency-validator.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@cost-efficiency-validator Analyze cloud spending trends for the last quarter and identify waste
@cost-efficiency-validator Recommend right-sizing for underutilized compute resources
@cost-efficiency-validator Project monthly costs for the proposed infrastructure changes
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/cost-efficiency-validator.prompt` | Guided workflow for Cost Efficiency Validator with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@cost-efficiency-validator Use when validating that modernized application meets cost efficiency targets compared to pre-modernization baseline.
```

#### Detailed Request
```
@cost-efficiency-validator I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Cost Efficiency Validator |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@cost-efficiency-validator`) |
| **Domain** | Cost |
| **Description** | Use when validating that modernized application meets cost efficiency targets compared to pre-modernization baseline. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **cost-efficiency-validator-skill** | Cost | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Cost Efficiency Validator operations |

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
| `cost-efficiency-validator-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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