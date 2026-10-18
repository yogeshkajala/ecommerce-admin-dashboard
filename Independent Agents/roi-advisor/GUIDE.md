# Roi Advisor -- User Guide

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
|   |   \-- roi-advisor/
|   |       \-- roi-advisor.agent.md
|   |-- skills/
|   |   \-- roi-advisor-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- roi-advisor.instructions.md
|   |-- hooks/
|   |   \-- roi-advisor-hook.json
|   |-- prompts/
|   |   \-- roi-advisor.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `ROI_ADVISOR_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `ROI_ADVISOR_DRY_RUN` | `false` | Preview changes without executing |
| `ROI_ADVISOR_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `ROI_ADVISOR_TIMEOUT` | `300` | Maximum execution time in seconds |
| `ROI_ADVISOR_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@roi-advisor`
4. Type `/` -- you should see `/roi-advisor.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@roi-advisor Analyze cloud spending trends for the last quarter and identify waste
@roi-advisor Recommend right-sizing for underutilized compute resources
@roi-advisor Project monthly costs for the proposed infrastructure changes
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/roi-advisor.prompt` | Guided workflow for Roi Advisor with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@roi-advisor Use when evaluating ROI for technology investments, building executive business cases, analyzing cost-benefit, projecting savings (NPV/IRR/payback), or comparing investment alternatives.
```

#### Detailed Request
```
@roi-advisor I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Roi Advisor |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@roi-advisor`) |
| **Domain** | Cost |
| **Description** | Use when evaluating ROI for technology investments, building executive business cases, analyzing cost-benefit, projecting savings (NPV/IRR/payback), or comparing investment alternatives. |
| **Tools** | read, search, agent, edit, vscode/askQuestions |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **roi-advisor-skill** | Cost | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Roi Advisor operations |

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
| `roi-advisor-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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