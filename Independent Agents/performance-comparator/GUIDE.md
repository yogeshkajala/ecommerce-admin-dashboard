# Performance Comparator -- User Guide

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
| **Metrics Platform** | Prometheus / Datadog / CloudWatch API credentials |
| **Log Platform** | Elasticsearch / Splunk / Loki API credentials |
| **Tracing Platform** | Jaeger / Zipkin / AWS X-Ray endpoint |
| **Dashboard** | Grafana API key for dashboard management |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- performance-comparator/
|   |       \-- performance-comparator.agent.md
|   |-- skills/
|   |   \-- performance-comparator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- performance-comparator.instructions.md
|   |-- hooks/
|   |   \-- performance-comparator-hook.json
|   |-- prompts/
|   |   \-- performance-comparator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `PERFORMANCE__RETENTION_DAYS` | `30` | Default telemetry retention period in days |
| `PERFORMANCE__ANOMALY_SENSITIVITY` | `medium` | Anomaly detection sensitivity: low, medium, high |
| `PERFORMANCE__CORRELATION_ENABLED` | `true` | Enable cross-signal correlation (metrics+logs+traces) |
| `PERFORMANCE__DASHBOARD_AUTO` | `true` | Auto-generate dashboards for new services |
| `PERFORMANCE__ALERT_DEDUP_WINDOW` | `5m` | Alert deduplication window |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@performance-comparator`
4. Type `/` -- you should see `/performance-comparator.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@performance-comparator Analyze latency anomalies in the order-service over the last 6 hours
@performance-comparator Create a dashboard for the checkout service with key SLI metrics
@performance-comparator Correlate error spikes in logs with metric changes for auth-service
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/performance-comparator.prompt` | Guided workflow for Performance Comparator with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@performance-comparator Use when comparing performance metrics between pre-upgrade and post-upgrade system states.
```

#### Detailed Request
```
@performance-comparator I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Performance Comparator |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@performance-comparator`) |
| **Domain** | Observability |
| **Description** | Use when comparing performance metrics between pre-upgrade and post-upgrade system states. |
| **Tools** | read, search, edit, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **performance-comparator-skill** | Observability | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Performance Comparator operations |

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
| `performance-comparator-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

### Telemetry Signal Matrix
| Signal | Tool | Use Case | Retention |
|--------|------|---------|-----------|
| **Metrics** | Prometheus / Datadog | SLIs, resource utilization, business KPIs | 30-90 days |
| **Logs** | ELK / Splunk / Loki | Error diagnosis, audit trail, debugging | 30-365 days |
| **Traces** | Jaeger / Zipkin / X-Ray | Request flow, latency breakdown, dependencies | 7-30 days |
| **Events** | Custom / CloudEvents | Deployments, config changes, incidents | 90-365 days |

### Alerting Best Practices
| Practice | Description | Priority |
|----------|------------|----------|
| **SLO-Based Alerts** | Alert on error budget burn rate, not raw metrics | Critical |
| **Multi-Window** | Use 5m + 1h + 6h windows to reduce noise | High |
| **Symptom-Based** | Alert on user-facing symptoms, not causes | High |
| **Runbook Links** | Every alert links to a remediation runbook | Medium |
| **Deduplication** | Group related alerts within time window | Medium |

### Industry Standards Built In
| Standard | Applied To |
|----------|-----------|
| **OpenTelemetry** | Vendor-neutral telemetry collection and export |
| **RED Method** | Rate, Errors, Duration for request-driven services |
| **USE Method** | Utilization, Saturation, Errors for resource monitoring |
| **Google SRE** | SLIs, SLOs, error budgets, alerting philosophy |
| **CNCF Observability** | Cloud-native observability best practices |