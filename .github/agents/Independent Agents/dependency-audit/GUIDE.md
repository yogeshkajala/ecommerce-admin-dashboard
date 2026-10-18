# Dependency Audit -- User Guide

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
|   |   \-- dependency-audit/
|   |       \-- dependency-audit.agent.md
|   |-- skills/
|   |   \-- dependency-audit-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- dependency-audit.instructions.md
|   |-- hooks/
|   |   \-- dependency-audit-hook.json
|   |-- prompts/
|   |   \-- dependency-audit.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPENDENCY_A_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DEPENDENCY_A_DRY_RUN` | `false` | Preview changes without executing |
| `DEPENDENCY_A_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DEPENDENCY_A_TIMEOUT` | `300` | Maximum execution time in seconds |
| `DEPENDENCY_A_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@dependency-audit`
4. Type `/` -- you should see `/dependency-audit.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@dependency-audit Audit access controls against SOC2 requirements
@dependency-audit Generate compliance report for upcoming GDPR audit
@dependency-audit Review policy violations across production infrastructure
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/dependency-audit.prompt` | Guided workflow for Dependency Audit with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@dependency-audit Use when auditing dependency health including CVEs, outdated packages, license compliance, and transitive dependency risks.
```

#### Detailed Request
```
@dependency-audit I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Dependency Audit |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@dependency-audit`) |
| **Domain** | Governance |
| **Description** | Use when auditing dependency health including CVEs, outdated packages, license compliance, and transitive dependency risks. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **dependency-audit-skill** | Governance | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Dependency Audit operations |

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
| `dependency-audit-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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