# User Impact Assessor -- User Guide

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
| **Container Registry** | Docker Hub / ACR / ECR / GCR credentials |
| **Orchestrator** | Kubernetes kubeconfig, Helm credentials, ArgoCD API token |
| **CI/CD Platform** | Jenkins / GitHub Actions / Azure DevOps / GitLab API token |
| **Monitoring** | Datadog / Grafana / Prometheus API key for deployment health checks |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- user-impact-assessor/
|   |       \-- user-impact-assessor.agent.md
|   |-- skills/
|   |   \-- user-impact-assessor-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- user-impact-assessor.instructions.md
|   |-- hooks/
|   |   \-- user-impact-assessor-hook.json
|   |-- prompts/
|   |   \-- user-impact-assessor.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `USER_IMPACT__STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `USER_IMPACT__HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `USER_IMPACT__ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `USER_IMPACT__APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `USER_IMPACT__NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@user-impact-assessor`
4. Type `/` -- you should see `/user-impact-assessor.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@user-impact-assessor Deploy version 2.1.0 to staging using blue-green strategy
@user-impact-assessor Run canary deployment of the checkout service to production at 10% traffic
@user-impact-assessor Rollback the last deployment of user-service in production
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/user-impact-assessor.prompt` | Guided workflow for User Impact Assessor with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@user-impact-assessor Use when assessing user impact from post-deployment anomalies including business KPI changes, user experience degradation, and conversion impacts.
```

#### Detailed Request
```
@user-impact-assessor I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | User Impact Assessor |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@user-impact-assessor`) |
| **Domain** | Deployment |
| **Description** | Use when assessing user impact from post-deployment anomalies including business KPI changes, user experience degradation, and conversion impacts. |
| **Tools** | read, search, edit, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **user-impact-assessor-skill** | Deployment | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for User Impact Assessor operations |

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
| `user-impact-assessor-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

### Deployment Strategy Matrix
| Strategy | Downtime | Risk | Rollback Speed | Use When |
|----------|----------|------|---------------|----------|
| **Rolling** | Zero | Medium | Minutes | Standard releases |
| **Blue-Green** | Zero | Low | Instant | Critical services |
| **Canary** | Zero | Lowest | Instant | High-risk changes |
| **Recreate** | Yes | High | Minutes | Dev/test environments |
| **A/B Testing** | Zero | Low | Instant | Feature experiments |

### Health Check Pipeline
| Stage | Check | Timeout | Failure Action |
|-------|-------|---------|---------------|
| **Pre-Deploy** | Artifact integrity, config validation | 60s | Abort deployment |
| **Deploy** | Container readiness, liveness probes | 300s | Retry or rollback |
| **Post-Deploy** | Smoke tests, integration checks | 120s | Auto-rollback |
| **Stabilization** | Error rate, latency, saturation | 600s | Alert and evaluate |

### Industry Standards Built In
| Standard | Applied To |
|----------|-----------|
| **DORA Metrics** | Deployment frequency, lead time, MTTR, change failure rate |
| **12-Factor App** | Config, dependencies, disposability, dev-prod parity |
| **GitOps (CNCF)** | Declarative infrastructure, version-controlled operations |
| **CIS Benchmarks** | Kubernetes, Docker, cloud provider security hardening |
| **SLSA Framework** | Supply chain security levels for software artifacts |