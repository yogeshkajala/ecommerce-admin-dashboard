# Build Automator -- User Guide

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
|   |   \-- build-automator/
|   |       \-- build-automator.agent.md
|   |-- skills/
|   |   \-- build-automator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- build-automator.instructions.md
|   |-- hooks/
|   |   \-- build-automator-hook.json
|   |-- prompts/
|   |   \-- build-automator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `BUILD_AUTOMA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `BUILD_AUTOMA_DRY_RUN` | `false` | Preview changes without executing |
| `BUILD_AUTOMA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `BUILD_AUTOMA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `BUILD_AUTOMA_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@build-automator`
4. Type `/` -- you should see `/build-automator.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@build-automator Analyze code quality and identify refactoring opportunities
@build-automator Review the pull request for best practices and potential issues
@build-automator Generate boilerplate code for a new microservice with standard patterns
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/build-automator.prompt` | Guided workflow for Build Automator with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@build-automator Use when configuring CI build pipelines, resolving dependencies, generating versioned artifacts, and producing SBOMs.
```

#### Detailed Request
```
@build-automator I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Build Automator |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@build-automator`) |
| **Domain** | Development |
| **Description** | Use when configuring CI build pipelines, resolving dependencies, generating versioned artifacts, and producing SBOMs. |
| **Tools** | read, search, execute |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **build-automator-skill** | Development | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Build Automator operations |

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
| `build-automator-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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