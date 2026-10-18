# Cicd Pipeline Builder -- User Guide

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
|   |   \-- cicd-pipeline-builder/
|   |       \-- cicd-pipeline-builder.agent.md
|   |-- skills/
|   |   \-- cicd-pipeline-builder-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- cicd-pipeline-builder.instructions.md
|   |-- hooks/
|   |   \-- cicd-pipeline-builder-hook.json
|   |-- prompts/
|   |   \-- cicd-pipeline-builder.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `CICD_PIPELIN_STRATEGY` | `rolling` | Default strategy: rolling, blue-green, canary, recreate |
| `CICD_PIPELIN_HEALTH_TIMEOUT` | `300` | Health check timeout in seconds |
| `CICD_PIPELIN_ROLLBACK_AUTO` | `true` | Automatic rollback on health check failure |
| `CICD_PIPELIN_APPROVAL_REQUIRED` | `true` | Require human approval for production deployments |
| `CICD_PIPELIN_NOTIFY_CHANNEL` | `slack` | Notification channel: slack, teams, email, pagerduty |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@cicd-pipeline-builder`
4. Type `/` -- you should see `/cicd-pipeline-builder.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@cicd-pipeline-builder Deploy version 2.1.0 to staging using blue-green strategy
@cicd-pipeline-builder Run canary deployment of the checkout service to production at 10% traffic
@cicd-pipeline-builder Rollback the last deployment of user-service in production
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/cicd-pipeline-builder.prompt` | Guided workflow for Cicd Pipeline Builder with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@cicd-pipeline-builder Use when building CI/CD pipelines for modernized application deployment with quality gates and progressive rollout stages.
```

#### Detailed Request
```
@cicd-pipeline-builder I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Cicd Pipeline Builder |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@cicd-pipeline-builder`) |
| **Domain** | Deployment |
| **Description** | Use when building CI/CD pipelines for modernized application deployment with quality gates and progressive rollout stages. |
| **Tools** | read, search, edit, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **cicd-pipeline-builder-skill** | Deployment | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Cicd Pipeline Builder operations |

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
| `cicd-pipeline-builder-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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