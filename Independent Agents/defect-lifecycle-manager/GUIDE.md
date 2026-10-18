# Defect Lifecycle Manager -- User Guide

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
|   |   \-- defect-lifecycle-manager/
|   |       \-- defect-lifecycle-manager.agent.md
|   |-- skills/
|   |   \-- defect-lifecycle-manager-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- defect-lifecycle-manager.instructions.md
|   |-- hooks/
|   |   \-- defect-lifecycle-manager-hook.json
|   |-- prompts/
|   |   \-- defect-lifecycle-manager.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `DEFECT_LIFEC_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `DEFECT_LIFEC_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `DEFECT_LIFEC_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `DEFECT_LIFEC_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `DEFECT_LIFEC_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@defect-lifecycle-manager`
4. Type `/` -- you should see `/defect-lifecycle-manager.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@defect-lifecycle-manager Triage this alert: high CPU on prod-api-server-03 for 15 minutes
@defect-lifecycle-manager Correlate recent alerts for the payment service and identify root cause
@defect-lifecycle-manager Generate postmortem report for INC-2024-0891
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/defect-lifecycle-manager.prompt` | Guided workflow for Defect Lifecycle Manager with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@defect-lifecycle-manager Use when managing the full defect lifecycle: detection, triage, root cause analysis, fix implementation, validation, and regression testing with severity-based SLAs.
```

#### Detailed Request
```
@defect-lifecycle-manager I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Defect Lifecycle Manager |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@defect-lifecycle-manager`) |
| **Domain** | Incident |
| **Description** | Use when managing the full defect lifecycle: detection, triage, root cause analysis, fix implementation, validation, and regression testing with severity-based SLAs. |
| **Tools** | read, search, agent, edit, execute, github/* |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **defect-lifecycle-manager-skill** | Incident | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Defect Lifecycle Manager operations |

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
| `defect-lifecycle-manager-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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