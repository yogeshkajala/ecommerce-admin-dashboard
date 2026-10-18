# Infra Provisioner -- User Guide

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
|   |   \-- infra-provisioner/
|   |       \-- infra-provisioner.agent.md
|   |-- skills/
|   |   \-- infra-provisioner-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- infra-provisioner.instructions.md
|   |-- hooks/
|   |   \-- infra-provisioner-hook.json
|   |-- prompts/
|   |   \-- infra-provisioner.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `INFRA_PROVIS_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `INFRA_PROVIS_DRY_RUN` | `false` | Preview changes without executing |
| `INFRA_PROVIS_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `INFRA_PROVIS_TIMEOUT` | `300` | Maximum execution time in seconds |
| `INFRA_PROVIS_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@infra-provisioner`
4. Type `/` -- you should see `/infra-provisioner.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@infra-provisioner Analyze infrastructure costs and recommend right-sizing for EC2 instances
@infra-provisioner Review Terraform configuration for security best practices
@infra-provisioner Plan capacity scaling for the holiday traffic surge
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/infra-provisioner.prompt` | Guided workflow for Infra Provisioner with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@infra-provisioner Use when provisioning target cloud infrastructure using IaC (Terraform, CloudFormation, Bicep) matching assessed requirements.
```

#### Detailed Request
```
@infra-provisioner I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Infra Provisioner |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@infra-provisioner`) |
| **Domain** | Infrastructure |
| **Description** | Use when provisioning target cloud infrastructure using IaC (Terraform, CloudFormation, Bicep) matching assessed requirements. |
| **Tools** | read, search, execute |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **infra-provisioner-skill** | Infrastructure | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Infra Provisioner operations |

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
| `infra-provisioner-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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