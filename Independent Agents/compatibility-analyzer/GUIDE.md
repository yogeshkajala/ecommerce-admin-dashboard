# Compatibility Analyzer -- User Guide

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
|   |   \-- compatibility-analyzer/
|   |       \-- compatibility-analyzer.agent.md
|   |-- skills/
|   |   \-- compatibility-analyzer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- compatibility-analyzer.instructions.md
|   |-- hooks/
|   |   \-- compatibility-analyzer-hook.json
|   |-- prompts/
|   |   \-- compatibility-analyzer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `COMPATIBILIT_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `COMPATIBILIT_DRY_RUN` | `false` | Preview changes without executing |
| `COMPATIBILIT_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `COMPATIBILIT_TIMEOUT` | `300` | Maximum execution time in seconds |
| `COMPATIBILIT_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@compatibility-analyzer`
4. Type `/` -- you should see `/compatibility-analyzer.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@compatibility-analyzer Analyze code quality and identify refactoring opportunities
@compatibility-analyzer Review the pull request for best practices and potential issues
@compatibility-analyzer Generate boilerplate code for a new microservice with standard patterns
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/compatibility-analyzer.prompt` | Guided workflow for Compatibility Analyzer with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@compatibility-analyzer Analyze compatibility between current code and target upgrade versions.
```

#### Detailed Request
```
@compatibility-analyzer I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Compatibility Analyzer |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@compatibility-analyzer`) |
| **Domain** | Development |
| **Description** | Analyze compatibility between current code and target upgrade versions. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **compatibility-analyzer-skill** | Development | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Compatibility Analyzer operations |

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
| `compatibility-analyzer-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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