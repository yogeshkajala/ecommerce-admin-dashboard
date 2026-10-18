# Auto Remediation Engine -- User Guide

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
| **Monitoring** | Prometheus / Datadog / New Relic API credentials |
| **Chaos Platform** | Gremlin / LitmusChaos / Chaos Monkey API token |
| **Incident Platform** | PagerDuty / OpsGenie API key |
| **Status Page** | Statuspage.io / Cachet API credentials |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- auto-remediation-engine/
|   |       \-- auto-remediation-engine.agent.md
|   |-- skills/
|   |   \-- auto-remediation-engine-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- auto-remediation-engine.instructions.md
|   |-- hooks/
|   |   \-- auto-remediation-engine-hook.json
|   |-- prompts/
|   |   \-- auto-remediation-engine.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `AUTO_REMEDIA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `AUTO_REMEDIA_DRY_RUN` | `false` | Preview changes without executing |
| `AUTO_REMEDIA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `AUTO_REMEDIA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `AUTO_REMEDIA_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@auto-remediation-engine`
4. Type `/` -- you should see `/auto-remediation-engine.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@auto-remediation-engine Calculate error budget consumption for the checkout service SLO
@auto-remediation-engine Plan chaos engineering experiment for the payment service
@auto-remediation-engine Review capacity against projected growth for Q4
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/auto-remediation-engine.prompt` | Guided workflow for Auto Remediation Engine with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@auto-remediation-engine Use when detecting and automatically fixing system failures, validating recovery, or recommending proactive optimizations.
```

#### Detailed Request
```
@auto-remediation-engine I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Auto Remediation Engine |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@auto-remediation-engine`) |
| **Domain** | Sre |
| **Description** | Use when detecting and automatically fixing system failures, validating recovery, or recommending proactive optimizations. |
| **Tools** | read, search, agent, execute |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **auto-remediation-engine-skill** | Sre | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Auto Remediation Engine operations |

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
| `auto-remediation-engine-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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
| **Google SRE** | Toil reduction, SLOs, error budgets, incident response |
| **DORA Metrics** | Deployment frequency, lead time, MTTR, change failure rate |
| **Chaos Engineering** | Principles of chaos -- steady state, hypothesis, minimize blast |
| **NIST SP 800-184** | Guide for cybersecurity event recovery |
| **ISO 22301** | Business continuity management systems |