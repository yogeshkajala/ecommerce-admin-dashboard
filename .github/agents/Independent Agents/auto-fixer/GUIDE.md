# Auto Fixer -- User Guide

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
|   |   \-- auto-fixer/
|   |       \-- auto-fixer.agent.md
|   |-- skills/
|   |   \-- auto-fixer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- auto-fixer.instructions.md
|   |-- hooks/
|   |   \-- auto-fixer-hook.json
|   |-- prompts/
|   |   \-- auto-fixer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `AUTO_FIXER_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `AUTO_FIXER_DRY_RUN` | `false` | Preview changes without executing |
| `AUTO_FIXER_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `AUTO_FIXER_TIMEOUT` | `300` | Maximum execution time in seconds |
| `AUTO_FIXER_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@auto-fixer`
4. Type `/` -- you should see `/auto-fixer.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@auto-fixer Analyze the current microservice architecture for anti-patterns
@auto-fixer Generate architecture decision record for the event-driven migration
@auto-fixer Review API design against REST best practices
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/auto-fixer.prompt` | Guided workflow for Auto Fixer with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@auto-fixer Use when applying automated fixes for detected failure patterns, including service restarts, scaling, and configuration corrections.
```

#### Detailed Request
```
@auto-fixer I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Auto Fixer |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@auto-fixer`) |
| **Domain** | Architecture |
| **Description** | Use when applying automated fixes for detected failure patterns, including service restarts, scaling, and configuration corrections. |
| **Tools** | read, search, execute |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **auto-fixer-skill** | Architecture | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Auto Fixer operations |

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
| `auto-fixer-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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