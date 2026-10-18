# Service Boundary Designer -- User Guide

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
|   |   \-- service-boundary-designer/
|   |       \-- service-boundary-designer.agent.md
|   |-- skills/
|   |   \-- service-boundary-designer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- service-boundary-designer.instructions.md
|   |-- hooks/
|   |   \-- service-boundary-designer-hook.json
|   |-- prompts/
|   |   \-- service-boundary-designer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `SERVICE_BOUN_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SERVICE_BOUN_DRY_RUN` | `false` | Preview changes without executing |
| `SERVICE_BOUN_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SERVICE_BOUN_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SERVICE_BOUN_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@service-boundary-designer`
4. Type `/` -- you should see `/service-boundary-designer.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@service-boundary-designer Analyze the current microservice architecture for anti-patterns
@service-boundary-designer Generate architecture decision record for the event-driven migration
@service-boundary-designer Review API design against REST best practices
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/service-boundary-designer.prompt` | Guided workflow for Service Boundary Designer with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@service-boundary-designer Use when defining microservice boundaries based on bounded contexts, ensuring each service owns a single domain.
```

#### Detailed Request
```
@service-boundary-designer I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Service Boundary Designer |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@service-boundary-designer`) |
| **Domain** | Architecture |
| **Description** | Use when defining microservice boundaries based on bounded contexts, ensuring each service owns a single domain. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **service-boundary-designer-skill** | Architecture | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Service Boundary Designer operations |

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
| `service-boundary-designer-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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