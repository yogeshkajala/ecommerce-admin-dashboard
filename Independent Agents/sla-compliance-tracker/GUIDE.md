# Sla Compliance Tracker -- User Guide

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
| **Compliance Platform** | Compliance tool API (Drata, Vanta, Tugboat Logic) |
| **CMDB** | ServiceNow / custom CMDB endpoint for asset inventory |
| **Audit Log** | Cloud audit trail API (CloudTrail, Azure Activity Log) |
| **Policy Engine** | OPA / Sentinel / Azure Policy API credentials |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- sla-compliance-tracker/
|   |       \-- sla-compliance-tracker.agent.md
|   |-- skills/
|   |   \-- sla-compliance-tracker-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- sla-compliance-tracker.instructions.md
|   |-- hooks/
|   |   \-- sla-compliance-tracker-hook.json
|   |-- prompts/
|   |   \-- sla-compliance-tracker.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `SLA_COMPLIAN_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SLA_COMPLIAN_DRY_RUN` | `false` | Preview changes without executing |
| `SLA_COMPLIAN_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SLA_COMPLIAN_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SLA_COMPLIAN_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@sla-compliance-tracker`
4. Type `/` -- you should see `/sla-compliance-tracker.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@sla-compliance-tracker Audit access controls against SOC2 requirements
@sla-compliance-tracker Generate compliance report for upcoming GDPR audit
@sla-compliance-tracker Review policy violations across production infrastructure
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/sla-compliance-tracker.prompt` | Guided workflow for Sla Compliance Tracker with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@sla-compliance-tracker Track SLA compliance metrics, monitor breach risk indicators, calculate error budgets, and assess penalty exposure for operational services.
```

#### Detailed Request
```
@sla-compliance-tracker I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Sla Compliance Tracker |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@sla-compliance-tracker`) |
| **Domain** | Governance |
| **Description** | Track SLA compliance metrics, monitor breach risk indicators, calculate error budgets, and assess penalty exposure for operational services. |
| **Tools** | read, search, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **sla-compliance-tracker-skill** | Governance | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Sla Compliance Tracker operations |

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
| `sla-compliance-tracker-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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
| **SOC 2 Type II** | Security, availability, processing integrity, confidentiality, privacy |
| **GDPR** | Data protection and privacy regulation |
| **ISO 27001** | Information security management system |
| **NIST RMF** | Risk management framework |
| **COBIT** | IT governance and management framework |