# Dns Cutover Executor -- User Guide

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
|   |   \-- dns-cutover-executor/
|   |       \-- dns-cutover-executor.agent.md
|   |-- skills/
|   |   \-- dns-cutover-executor-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- dns-cutover-executor.instructions.md
|   |-- hooks/
|   |   \-- dns-cutover-executor-hook.json
|   |-- prompts/
|   |   \-- dns-cutover-executor.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `DNS_CUTOVER__MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DNS_CUTOVER__DRY_RUN` | `false` | Preview changes without executing |
| `DNS_CUTOVER__LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DNS_CUTOVER__TIMEOUT` | `300` | Maximum execution time in seconds |
| `DNS_CUTOVER__NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@dns-cutover-executor`
4. Type `/` -- you should see `/dns-cutover-executor.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@dns-cutover-executor Analyze infrastructure costs and recommend right-sizing for EC2 instances
@dns-cutover-executor Review Terraform configuration for security best practices
@dns-cutover-executor Plan capacity scaling for the holiday traffic surge
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/dns-cutover-executor.prompt` | Guided workflow for Dns Cutover Executor with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@dns-cutover-executor Use when executing DNS cutover, traffic shifting, and load balancer reconfiguration during migration cutover windows.
```

#### Detailed Request
```
@dns-cutover-executor I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Dns Cutover Executor |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@dns-cutover-executor`) |
| **Domain** | Infrastructure |
| **Description** | Use when executing DNS cutover, traffic shifting, and load balancer reconfiguration during migration cutover windows. |
| **Tools** | read, search, execute |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **dns-cutover-executor-skill** | Infrastructure | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Dns Cutover Executor operations |

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
| `dns-cutover-executor-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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