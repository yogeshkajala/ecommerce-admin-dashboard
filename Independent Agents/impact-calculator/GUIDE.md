# Impact Calculator -- User Guide

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
|   |   \-- impact-calculator/
|   |       \-- impact-calculator.agent.md
|   |-- skills/
|   |   \-- impact-calculator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- impact-calculator.instructions.md
|   |-- hooks/
|   |   \-- impact-calculator-hook.json
|   |-- prompts/
|   |   \-- impact-calculator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `IMPACT_CALCU_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `IMPACT_CALCU_DRY_RUN` | `false` | Preview changes without executing |
| `IMPACT_CALCU_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `IMPACT_CALCU_TIMEOUT` | `300` | Maximum execution time in seconds |
| `IMPACT_CALCU_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@impact-calculator`
4. Type `/` -- you should see `/impact-calculator.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@impact-calculator Analyze code quality and identify refactoring opportunities
@impact-calculator Review the pull request for best practices and potential issues
@impact-calculator Generate boilerplate code for a new microservice with standard patterns
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/impact-calculator.prompt` | Guided workflow for Impact Calculator with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@impact-calculator Calculate blast radius, cascading failure paths, and downstream impact for proposed changes, failures, or maintenance operations.
```

#### Detailed Request
```
@impact-calculator I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Impact Calculator |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@impact-calculator`) |
| **Domain** | Development |
| **Description** | Calculate blast radius, cascading failure paths, and downstream impact for proposed changes, failures, or maintenance operations. |
| **Tools** | read, search, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **impact-calculator-skill** | Development | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Impact Calculator operations |

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
| `impact-calculator-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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