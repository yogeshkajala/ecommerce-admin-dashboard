# Microservice Architect -- User Guide

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
|   |   \-- microservice-architect/
|   |       \-- microservice-architect.agent.md
|   |-- skills/
|   |   \-- microservice-architect-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- microservice-architect.instructions.md
|   |-- hooks/
|   |   \-- microservice-architect-hook.json
|   |-- prompts/
|   |   \-- microservice-architect.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `MICROSERVICE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `MICROSERVICE_DRY_RUN` | `false` | Preview changes without executing |
| `MICROSERVICE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `MICROSERVICE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `MICROSERVICE_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@microservice-architect`
4. Type `/` -- you should see `/microservice-architect.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@microservice-architect Analyze the current microservice architecture for anti-patterns
@microservice-architect Generate architecture decision record for the event-driven migration
@microservice-architect Review API design against REST best practices
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/microservice-architect.prompt` | Guided workflow for Microservice Architect with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@microservice-architect Use when designing microservice boundaries, data ownership, event contracts, and API gateway patterns.
```

#### Detailed Request
```
@microservice-architect I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Microservice Architect |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@microservice-architect`) |
| **Domain** | Architecture |
| **Description** | Use when designing microservice boundaries, data ownership, event contracts, and API gateway patterns. |
| **Tools** | read, search, agent |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **microservice-architect-skill** | Architecture | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Microservice Architect operations |

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
| `microservice-architect-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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