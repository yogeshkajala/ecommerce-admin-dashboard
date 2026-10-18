# Batch Job Migrator -- User Guide

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
|   |   \-- batch-job-migrator/
|   |       \-- batch-job-migrator.agent.md
|   |-- skills/
|   |   \-- batch-job-migrator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- batch-job-migrator.instructions.md
|   |-- hooks/
|   |   \-- batch-job-migrator-hook.json
|   |-- prompts/
|   |   \-- batch-job-migrator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `BATCH_JOB_MI_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `BATCH_JOB_MI_DRY_RUN` | `false` | Preview changes without executing |
| `BATCH_JOB_MI_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `BATCH_JOB_MI_TIMEOUT` | `300` | Maximum execution time in seconds |
| `BATCH_JOB_MI_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@batch-job-migrator`
4. Type `/` -- you should see `/batch-job-migrator.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@batch-job-migrator Assess the legacy monolith for microservice migration readiness
@batch-job-migrator Plan incremental migration of the user module from .NET 4.8 to .NET 8
@batch-job-migrator Analyze database schema compatibility for PostgreSQL to Aurora migration
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/batch-job-migrator.prompt` | Guided workflow for Batch Job Migrator with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@batch-job-migrator Use when migrating legacy batch jobs to modern scheduling systems with equivalent functionality.
```

#### Detailed Request
```
@batch-job-migrator I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Batch Job Migrator |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@batch-job-migrator`) |
| **Domain** | Migration |
| **Description** | Use when migrating legacy batch jobs to modern scheduling systems with equivalent functionality. |
| **Tools** | read, search, edit |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **batch-job-migrator-skill** | Migration | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Batch Job Migrator operations |

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
| `batch-job-migrator-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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