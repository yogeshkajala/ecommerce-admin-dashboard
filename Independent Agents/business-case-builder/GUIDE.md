# Business Case Builder -- User Guide

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
| **SCM** | GitHub / GitLab / Azure DevOps API token |
| **CI/CD** | Pipeline API credentials for build automation |
| **Code Quality** | SonarQube / CodeClimate API credentials |
| **Package Registry** | npm / PyPI / Maven / NuGet credentials |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- business-case-builder/
|   |       \-- business-case-builder.agent.md
|   |-- skills/
|   |   \-- business-case-builder-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- business-case-builder.instructions.md
|   |-- hooks/
|   |   \-- business-case-builder-hook.json
|   |-- prompts/
|   |   \-- business-case-builder.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `BUSINESS_CAS_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `BUSINESS_CAS_DRY_RUN` | `false` | Preview changes without executing |
| `BUSINESS_CAS_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `BUSINESS_CAS_TIMEOUT` | `300` | Maximum execution time in seconds |
| `BUSINESS_CAS_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@business-case-builder`
4. Type `/` -- you should see `/business-case-builder.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@business-case-builder Analyze code quality and identify refactoring opportunities
@business-case-builder Review the pull request for best practices and potential issues
@business-case-builder Generate boilerplate code for a new microservice with standard patterns
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/business-case-builder.prompt` | Guided workflow for Business Case Builder with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@business-case-builder Use when building the financial business case for cloud modernization including ROI, TCO, and risk analysis.
```

#### Detailed Request
```
@business-case-builder I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Business Case Builder |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@business-case-builder`) |
| **Domain** | Development |
| **Description** | Use when building the financial business case for cloud modernization including ROI, TCO, and risk analysis. |
| **Tools** | read, search, edit, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **business-case-builder-skill** | Development | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Business Case Builder operations |

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
| `business-case-builder-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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