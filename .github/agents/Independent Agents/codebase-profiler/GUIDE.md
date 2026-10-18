# Codebase Profiler -- User Guide

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
|   |   \-- codebase-profiler/
|   |       \-- codebase-profiler.agent.md
|   |-- skills/
|   |   \-- codebase-profiler-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- codebase-profiler.instructions.md
|   |-- hooks/
|   |   \-- codebase-profiler-hook.json
|   |-- prompts/
|   |   \-- codebase-profiler.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `CODEBASE_PRO_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CODEBASE_PRO_DRY_RUN` | `false` | Preview changes without executing |
| `CODEBASE_PRO_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CODEBASE_PRO_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CODEBASE_PRO_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@codebase-profiler`
4. Type `/` -- you should see `/codebase-profiler.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@codebase-profiler Analyze code quality and identify refactoring opportunities
@codebase-profiler Review the pull request for best practices and potential issues
@codebase-profiler Generate boilerplate code for a new microservice with standard patterns
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/codebase-profiler.prompt` | Guided workflow for Codebase Profiler with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@codebase-profiler Use when profiling a codebase for tech stack detection, test coverage analysis, CI/CD pipeline inventory, database technology mapping, or generating a repository health overview.
```

#### Detailed Request
```
@codebase-profiler I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Codebase Profiler |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@codebase-profiler`) |
| **Domain** | Development |
| **Description** | Use when profiling a codebase for tech stack detection, test coverage analysis, CI/CD pipeline inventory, database technology mapping, or generating a repository health overview. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **codebase-profiler-skill** | Development | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Codebase Profiler operations |

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
| `codebase-profiler-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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