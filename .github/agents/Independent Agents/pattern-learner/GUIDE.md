# Pattern Learner -- User Guide

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
|   |   \-- pattern-learner/
|   |       \-- pattern-learner.agent.md
|   |-- skills/
|   |   \-- pattern-learner-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- pattern-learner.instructions.md
|   |-- hooks/
|   |   \-- pattern-learner-hook.json
|   |-- prompts/
|   |   \-- pattern-learner.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `PATTERN_LEAR_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `PATTERN_LEAR_DRY_RUN` | `false` | Preview changes without executing |
| `PATTERN_LEAR_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `PATTERN_LEAR_TIMEOUT` | `300` | Maximum execution time in seconds |
| `PATTERN_LEAR_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@pattern-learner`
4. Type `/` -- you should see `/pattern-learner.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@pattern-learner Analyze the current microservice architecture for anti-patterns
@pattern-learner Generate architecture decision record for the event-driven migration
@pattern-learner Review API design against REST best practices
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/pattern-learner.prompt` | Guided workflow for Pattern Learner with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@pattern-learner Learn from incident outcomes to create new symptom patterns, improve match accuracy, and expand the automated remediation knowledge base.
```

#### Detailed Request
```
@pattern-learner I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Pattern Learner |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@pattern-learner`) |
| **Domain** | Architecture |
| **Description** | Learn from incident outcomes to create new symptom patterns, improve match accuracy, and expand the automated remediation knowledge base. |
| **Tools** | read, search, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **pattern-learner-skill** | Architecture | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Pattern Learner operations |

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
| `pattern-learner-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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