# Impact Analyzer -- User Guide

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
|   |   \-- impact-analyzer/
|   |       \-- impact-analyzer.agent.md
|   |-- skills/
|   |   \-- impact-analyzer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- impact-analyzer.instructions.md
|   |-- hooks/
|   |   \-- impact-analyzer-hook.json
|   |-- prompts/
|   |   \-- impact-analyzer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `IMPACT_ANALY_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `IMPACT_ANALY_DRY_RUN` | `false` | Preview changes without executing |
| `IMPACT_ANALY_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `IMPACT_ANALY_TIMEOUT` | `300` | Maximum execution time in seconds |
| `IMPACT_ANALY_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@impact-analyzer`
4. Type `/` -- you should see `/impact-analyzer.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@impact-analyzer Analyze code quality and identify refactoring opportunities
@impact-analyzer Review the pull request for best practices and potential issues
@impact-analyzer Generate boilerplate code for a new microservice with standard patterns
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/impact-analyzer.prompt` | Guided workflow for Impact Analyzer with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@impact-analyzer Use when analyzing codebase impact of proposed changes including dependency mapping, risk assessment, and effort estimation.
```

#### Detailed Request
```
@impact-analyzer I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Impact Analyzer |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@impact-analyzer`) |
| **Domain** | Development |
| **Description** | Use when analyzing codebase impact of proposed changes including dependency mapping, risk assessment, and effort estimation. |
| **Tools** | read, search, agent |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **impact-analyzer-skill** | Development | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Impact Analyzer operations |

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
| `impact-analyzer-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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