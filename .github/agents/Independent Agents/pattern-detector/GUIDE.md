# Pattern Detector -- User Guide

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
|   |   \-- pattern-detector/
|   |       \-- pattern-detector.agent.md
|   |-- skills/
|   |   \-- pattern-detector-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- pattern-detector.instructions.md
|   |-- hooks/
|   |   \-- pattern-detector-hook.json
|   |-- prompts/
|   |   \-- pattern-detector.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `PATTERN_DETE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `PATTERN_DETE_DRY_RUN` | `false` | Preview changes without executing |
| `PATTERN_DETE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `PATTERN_DETE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `PATTERN_DETE_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@pattern-detector`
4. Type `/` -- you should see `/pattern-detector.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@pattern-detector Analyze the current microservice architecture for anti-patterns
@pattern-detector Generate architecture decision record for the event-driven migration
@pattern-detector Review API design against REST best practices
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/pattern-detector.prompt` | Guided workflow for Pattern Detector with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@pattern-detector Use when detecting prompt injection patterns, identifying adversarial prompt techniques, matching known injection signatures, or analyzing inputs for novel attack vectors.
```

#### Detailed Request
```
@pattern-detector I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Pattern Detector |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@pattern-detector`) |
| **Domain** | Architecture |
| **Description** | Use when detecting prompt injection patterns, identifying adversarial prompt techniques, matching known injection signatures, or analyzing inputs for novel attack vectors. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **pattern-detector-skill** | Architecture | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Pattern Detector operations |

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
| `pattern-detector-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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