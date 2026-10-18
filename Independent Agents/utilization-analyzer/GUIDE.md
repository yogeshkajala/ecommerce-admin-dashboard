# Utilization Analyzer -- User Guide

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
| **Cloud Provider** | AWS IAM / Azure Service Principal / GCP Service Account credentials |
| **IaC Tool** | Terraform Cloud / Pulumi API token |
| **Monitoring** | CloudWatch / Azure Monitor / Stackdriver API credentials |
| **DNS Provider** | Route53 / Cloudflare / Azure DNS API credentials |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- utilization-analyzer/
|   |       \-- utilization-analyzer.agent.md
|   |-- skills/
|   |   \-- utilization-analyzer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- utilization-analyzer.instructions.md
|   |-- hooks/
|   |   \-- utilization-analyzer-hook.json
|   |-- prompts/
|   |   \-- utilization-analyzer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `UTILIZATION__MODE` | `standard` | Operation mode: quick, standard, thorough |
| `UTILIZATION__DRY_RUN` | `false` | Preview changes without executing |
| `UTILIZATION__LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `UTILIZATION__TIMEOUT` | `300` | Maximum execution time in seconds |
| `UTILIZATION__NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@utilization-analyzer`
4. Type `/` -- you should see `/utilization-analyzer.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@utilization-analyzer Analyze infrastructure costs and recommend right-sizing for EC2 instances
@utilization-analyzer Review Terraform configuration for security best practices
@utilization-analyzer Plan capacity scaling for the holiday traffic surge
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/utilization-analyzer.prompt` | Guided workflow for Utilization Analyzer with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@utilization-analyzer Analyze resource utilization across compute, memory, storage, and network to identify waste, bottlenecks, and right-sizing opportunities.
```

#### Detailed Request
```
@utilization-analyzer I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Utilization Analyzer |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@utilization-analyzer`) |
| **Domain** | Infrastructure |
| **Description** | Analyze resource utilization across compute, memory, storage, and network to identify waste, bottlenecks, and right-sizing opportunities. |
| **Tools** | read, search, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **utilization-analyzer-skill** | Infrastructure | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Utilization Analyzer operations |

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
| `utilization-analyzer-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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