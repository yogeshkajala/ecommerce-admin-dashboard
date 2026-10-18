# Cloud Migration Architect -- User Guide

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
| **Source Platform** | API credentials for legacy system access |
| **Target Platform** | Cloud provider credentials (AWS/Azure/GCP) |
| **Database** | Connection strings for source and target databases |
| **CI/CD** | Pipeline API token for migration automation |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- cloud-migration-architect/
|   |       \-- cloud-migration-architect.agent.md
|   |-- skills/
|   |   \-- cloud-migration-architect-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- cloud-migration-architect.instructions.md
|   |-- hooks/
|   |   \-- cloud-migration-architect-hook.json
|   |-- prompts/
|   |   \-- cloud-migration-architect.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `CLOUD_MIGRAT_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `CLOUD_MIGRAT_DRY_RUN` | `false` | Preview changes without executing |
| `CLOUD_MIGRAT_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `CLOUD_MIGRAT_TIMEOUT` | `300` | Maximum execution time in seconds |
| `CLOUD_MIGRAT_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@cloud-migration-architect`
4. Type `/` -- you should see `/cloud-migration-architect.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@cloud-migration-architect Assess the legacy monolith for microservice migration readiness
@cloud-migration-architect Plan incremental migration of the user module from .NET 4.8 to .NET 8
@cloud-migration-architect Analyze database schema compatibility for PostgreSQL to Aurora migration
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/cloud-migration-architect.prompt` | Guided workflow for Cloud Migration Architect with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@cloud-migration-architect Use when designing target cloud architecture, networking, security, and data migration strategy for cloud migration.
```

#### Detailed Request
```
@cloud-migration-architect I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Cloud Migration Architect |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@cloud-migration-architect`) |
| **Domain** | Migration |
| **Description** | Use when designing target cloud architecture, networking, security, and data migration strategy for cloud migration. |
| **Tools** | read, search, agent, edit, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **cloud-migration-architect-skill** | Migration | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Cloud Migration Architect operations |

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
| `cloud-migration-architect-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

### Migration Strategy Decision Matrix
| Strategy | Risk | Duration | Downtime | Best For |
|----------|------|----------|----------|----------|
| **Lift and Shift** | Low | Short | Minimal | Quick cloud migration |
| **Re-Platform** | Medium | Medium | Planned | Database/runtime upgrades |
| **Re-Factor** | High | Long | Staged | Architecture modernization |
| **Re-Build** | Highest | Longest | Staged | Complete technology change |
| **Strangler Fig** | Medium | Long | Zero | Incremental decomposition |

### Migration Readiness Scorecard
| Dimension | Weight | Criteria |
|-----------|--------|----------|
| **Code Quality** | 25% | Test coverage, complexity, tech debt score |
| **Dependencies** | 20% | External service coupling, library compatibility |
| **Data** | 20% | Schema complexity, data volume, migration tools |
| **Team Readiness** | 15% | Skills, training needs, capacity |
| **Risk** | 20% | Business criticality, rollback complexity, compliance |

### Industry Standards Built In
| Standard | Applied To |
|----------|-----------|
| **ITIL v4** | Service management best practices |
| **ISO 20000** | IT service management standard |
| **COBIT** | IT governance and management framework |
| **TOGAF** | Enterprise architecture methodology |
| **SAFe** | Scaled agile framework for enterprise |