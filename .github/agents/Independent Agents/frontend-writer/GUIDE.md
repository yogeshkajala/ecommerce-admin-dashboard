# Frontend Writer -- User Guide

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
| **Diagramming** | Mermaid / PlantUML / Draw.io integration |
| **API Platform** | Swagger / OpenAPI spec hosting endpoint |
| **Registry** | Service registry / API gateway management endpoint |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- frontend-writer/
|   |       \-- frontend-writer.agent.md
|   |-- skills/
|   |   \-- frontend-writer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- frontend-writer.instructions.md
|   |-- hooks/
|   |   \-- frontend-writer-hook.json
|   |-- prompts/
|   |   \-- frontend-writer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `FRONTEND_WRI_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `FRONTEND_WRI_DRY_RUN` | `false` | Preview changes without executing |
| `FRONTEND_WRI_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `FRONTEND_WRI_TIMEOUT` | `300` | Maximum execution time in seconds |
| `FRONTEND_WRI_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@frontend-writer`
4. Type `/` -- you should see `/frontend-writer.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@frontend-writer Analyze the current microservice architecture for anti-patterns
@frontend-writer Generate architecture decision record for the event-driven migration
@frontend-writer Review API design against REST best practices
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/frontend-writer.prompt` | Guided workflow for Frontend Writer with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@frontend-writer Use when generating client-side code: UI components, pages, forms, routing, state management, and API client integration.
```

#### Detailed Request
```
@frontend-writer I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Frontend Writer |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@frontend-writer`) |
| **Domain** | Architecture |
| **Description** | Use when generating client-side code: UI components, pages, forms, routing, state management, and API client integration. |
| **Tools** | read, search, editFiles, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **frontend-writer-skill** | Architecture | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Frontend Writer operations |

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
| `frontend-writer-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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