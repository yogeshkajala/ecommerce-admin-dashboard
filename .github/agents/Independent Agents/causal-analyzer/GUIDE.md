# Causal Analyzer -- User Guide

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
|   |   \-- causal-analyzer/
|   |       \-- causal-analyzer.agent.md
|   |-- skills/
|   |   \-- causal-analyzer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- causal-analyzer.instructions.md
|   |-- hooks/
|   |   \-- causal-analyzer-hook.json
|   |-- prompts/
|   |   \-- causal-analyzer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `CAUSAL_ANALY_AUTO_ESCALATE` | `true` | Auto-escalate SEV1/SEV2 to on-call |
| `CAUSAL_ANALY_CORRELATION_WINDOW` | `15m` | Time window for alert correlation |
| `CAUSAL_ANALY_POSTMORTEM_AUTO` | `true` | Auto-generate postmortem template on resolution |
| `CAUSAL_ANALY_NOTIFY_STAKEHOLDERS` | `true` | Notify stakeholders on severity change |
| `CAUSAL_ANALY_RCA_DEPTH` | `3` | Root cause analysis depth (5-whys iterations) |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@causal-analyzer`
4. Type `/` -- you should see `/causal-analyzer.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@causal-analyzer Triage this alert: high CPU on prod-api-server-03 for 15 minutes
@causal-analyzer Correlate recent alerts for the payment service and identify root cause
@causal-analyzer Generate postmortem report for INC-2024-0891
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/causal-analyzer.prompt` | Guided workflow for Causal Analyzer with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@causal-analyzer Determine root cause of incidents using systematic causal analysis.
```

#### Detailed Request
```
@causal-analyzer I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Causal Analyzer |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@causal-analyzer`) |
| **Domain** | Incident |
| **Description** | Determine root cause of incidents using systematic causal analysis. |
| **Tools** | read, search, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **causal-analyzer-skill** | Incident | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Causal Analyzer operations |

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
| `causal-analyzer-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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