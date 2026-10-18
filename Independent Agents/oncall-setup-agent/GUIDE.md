# Oncall Setup Agent -- User Guide

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
| **Alerting Platform** | PagerDuty / OpsGenie / VictorOps API key |
| **ITSM** | ServiceNow / Jira Service Management API token |
| **Communication** | Slack / Microsoft Teams webhook URL |
| **Monitoring** | Datadog / Grafana / Prometheus API key for alert correlation |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- oncall-setup-agent/
|   |       \-- oncall-setup-agent.agent.md
|   |-- skills/
|   |   \-- oncall-setup-agent-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- oncall-setup-agent.instructions.md
|   |-- hooks/
|   |   \-- oncall-setup-agent-hook.json
|   |-- prompts/
|   |   \-- oncall-setup-agent.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `ONCALL_SETUP_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `ONCALL_SETUP_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `ONCALL_SETUP_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `ONCALL_SETUP_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `ONCALL_SETUP_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@oncall-setup-agent`
4. Type `/` -- you should see `/oncall-setup-agent.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@oncall-setup-agent Triage this alert: high CPU on prod-api-server-03 for 15 minutes
@oncall-setup-agent Correlate recent alerts for the payment service and identify root cause
@oncall-setup-agent Generate postmortem report for INC-2024-0891
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/oncall-setup-agent.prompt` | Guided workflow for Oncall Setup Agent with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@oncall-setup-agent Use when configuring on-call rotations, escalation policies, paging rules, and incident response tooling for production support.
```

#### Detailed Request
```
@oncall-setup-agent I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Oncall Setup Agent |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@oncall-setup-agent`) |
| **Domain** | Incident |
| **Description** | Use when configuring on-call rotations, escalation policies, paging rules, and incident response tooling for production support. |
| **Tools** | read, search, edit, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **oncall-setup-agent-skill** | Incident | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Oncall Setup Agent operations |

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
| `oncall-setup-agent-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

### Severity Classification
| Level | Impact | Response Time | Escalation | Example |
|-------|--------|--------------|------------|---------|
| **SEV1** | Critical -- revenue/safety impact | 5 minutes | VP Engineering + CTO | Full outage, data breach |
| **SEV2** | Major -- significant user impact | 15 minutes | Engineering Manager | Partial outage, degraded perf |
| **SEV3** | Minor -- limited user impact | 1 hour | Team Lead | Single feature down |
| **SEV4** | Low -- no user impact | 4 hours | Sprint backlog | Internal tool issue |

### Incident Response Flow
| Phase | Duration | Key Actions | Output |
|-------|----------|------------|--------|
| **Detection** | 0-5 min | Alert fires, on-call paged | Incident created |
| **Triage** | 5-15 min | Severity assessed, team assembled | Response plan |
| **Diagnosis** | 15-60 min | Root cause investigation | RCA hypothesis |
| **Remediation** | Varies | Fix applied, validated | Service restored |
| **Post-Incident** | 24-48 hrs | Postmortem, action items | Prevention plan |

### Industry Standards Built In
| Standard | Applied To |
|----------|-----------|
| **ITIL v4** | Incident management, problem management, change enablement |
| **PagerDuty Response** | Incident response best practices, escalation, communication |
| **Google SRE** | Incident command, postmortem culture, blameless reviews |
| **NIST SP 800-61** | Computer security incident handling guide |
| **ISO 20000** | IT service management standard |