# Hallucination Shield -- User Guide

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
|   |   \-- hallucination-shield/
|   |       \-- hallucination-shield.agent.md
|   |-- skills/
|   |   \-- hallucination-shield-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- hallucination-shield.instructions.md
|   |-- hooks/
|   |   \-- hallucination-shield-hook.json
|   |-- prompts/
|   |   \-- hallucination-shield.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `HALLUCINATIO_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `HALLUCINATIO_DRY_RUN` | `false` | Preview changes without executing |
| `HALLUCINATIO_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `HALLUCINATIO_TIMEOUT` | `300` | Maximum execution time in seconds |
| `HALLUCINATIO_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@hallucination-shield`
4. Type `/` -- you should see `/hallucination-shield.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@hallucination-shield Analyze and provide recommendations for the target system
@hallucination-shield Execute the standard workflow with validation checkpoints
@hallucination-shield Generate a comprehensive report with findings and action items
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/hallucination-shield.prompt` | Guided workflow for Hallucination Shield with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@hallucination-shield Use when verifying AI-generated outputs for hallucinations, grounding claims in evidence, calibrating confidence scores, or validating structured output schemas.
```

#### Detailed Request
```
@hallucination-shield I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Hallucination Shield |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@hallucination-shield`) |
| **Domain** | Ai Safety |
| **Description** | Use when verifying AI-generated outputs for hallucinations, grounding claims in evidence, calibrating confidence scores, or validating structured output schemas. |
| **Tools** | read, search, agent |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **hallucination-shield-skill** | Ai Safety | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Hallucination Shield operations |

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
| `hallucination-shield-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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