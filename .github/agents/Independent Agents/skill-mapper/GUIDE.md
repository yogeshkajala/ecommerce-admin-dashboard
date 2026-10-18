# Skill Mapper -- User Guide

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
| **Project Tool** | Jira / Azure Boards / Trello API token |
| **Communication** | Slack / Microsoft Teams webhook URL |
| **Reporting** | Power BI / Tableau / custom dashboard API |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- skill-mapper/
|   |       \-- skill-mapper.agent.md
|   |-- skills/
|   |   \-- skill-mapper-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- skill-mapper.instructions.md
|   |-- hooks/
|   |   \-- skill-mapper-hook.json
|   |-- prompts/
|   |   \-- skill-mapper.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `SKILL_MAPPER_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SKILL_MAPPER_DRY_RUN` | `false` | Preview changes without executing |
| `SKILL_MAPPER_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SKILL_MAPPER_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SKILL_MAPPER_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@skill-mapper`
4. Type `/` -- you should see `/skill-mapper.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@skill-mapper Generate sprint report for Sprint 24 with velocity metrics
@skill-mapper Analyze backlog health and recommend prioritization adjustments
@skill-mapper Create release plan for version 3.0 with dependency mapping
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/skill-mapper.prompt` | Guided workflow for Skill Mapper with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@skill-mapper Use when mapping project skill requirements against team capabilities and identifying gaps with training or hiring plans.
```

#### Detailed Request
```
@skill-mapper I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Skill Mapper |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@skill-mapper`) |
| **Domain** | Project |
| **Description** | Use when mapping project skill requirements against team capabilities and identifying gaps with training or hiring plans. |
| **Tools** | read, search, edit, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **skill-mapper-skill** | Project | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Skill Mapper operations |

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
| `skill-mapper-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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