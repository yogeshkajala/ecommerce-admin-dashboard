# Dependency Resolver -- User Guide

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
|   |   \-- dependency-resolver/
|   |       \-- dependency-resolver.agent.md
|   |-- skills/
|   |   \-- dependency-resolver-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- dependency-resolver.instructions.md
|   |-- hooks/
|   |   \-- dependency-resolver-hook.json
|   |-- prompts/
|   |   \-- dependency-resolver.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEPENDENCY_R_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DEPENDENCY_R_DRY_RUN` | `false` | Preview changes without executing |
| `DEPENDENCY_R_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DEPENDENCY_R_TIMEOUT` | `300` | Maximum execution time in seconds |
| `DEPENDENCY_R_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@dependency-resolver`
4. Type `/` -- you should see `/dependency-resolver.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@dependency-resolver Analyze and provide recommendations for the target system
@dependency-resolver Execute the standard workflow with validation checkpoints
@dependency-resolver Generate a comprehensive report with findings and action items
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/dependency-resolver.prompt` | Guided workflow for Dependency Resolver with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@dependency-resolver Use when resolving and locking dependencies with integrity verification and CVE scanning.
```

#### Detailed Request
```
@dependency-resolver I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Dependency Resolver |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@dependency-resolver`) |
| **Domain** | Ai Safety |
| **Description** | Use when resolving and locking dependencies with integrity verification and CVE scanning. |
| **Tools** | read, search, execute |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **dependency-resolver-skill** | Ai Safety | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Dependency Resolver operations |

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
| `dependency-resolver-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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