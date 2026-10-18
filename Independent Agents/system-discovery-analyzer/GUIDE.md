# System Discovery Analyzer -- User Guide

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
| **Database** | Connection string / credentials for target database |
| **Monitoring** | Database monitoring tool API (pganalyze, PMM, CloudWatch) |
| **Backup Service** | Backup storage credentials (S3, Azure Blob, GCS) |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- system-discovery-analyzer/
|   |       \-- system-discovery-analyzer.agent.md
|   |-- skills/
|   |   \-- system-discovery-analyzer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- system-discovery-analyzer.instructions.md
|   |-- hooks/
|   |   \-- system-discovery-analyzer-hook.json
|   |-- prompts/
|   |   \-- system-discovery-analyzer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `SYSTEM_DISCO_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SYSTEM_DISCO_DRY_RUN` | `false` | Preview changes without executing |
| `SYSTEM_DISCO_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SYSTEM_DISCO_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SYSTEM_DISCO_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@system-discovery-analyzer`
4. Type `/` -- you should see `/system-discovery-analyzer.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@system-discovery-analyzer Optimize slow queries in the orders table taking over 2 seconds
@system-discovery-analyzer Plan database migration from PostgreSQL 13 to PostgreSQL 16
@system-discovery-analyzer Analyze index usage and recommend improvements for the users database
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/system-discovery-analyzer.prompt` | Guided workflow for System Discovery Analyzer with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@system-discovery-analyzer Discover systems, services, APIs, databases, integrations, and external dependencies in a codebase.
```

#### Detailed Request
```
@system-discovery-analyzer I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | System Discovery Analyzer |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@system-discovery-analyzer`) |
| **Domain** | Database |
| **Description** | Discover systems, services, APIs, databases, integrations, and external dependencies in a codebase. |
| **Tools** | read, search, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **system-discovery-analyzer-skill** | Database | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for System Discovery Analyzer operations |

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
| `system-discovery-analyzer-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

### Query Performance Tiers
| Tier | Response Time | Action | SLA |
|------|-------------|--------|-----|
| **Optimal** | < 50ms | No action needed | Target |
| **Acceptable** | 50-200ms | Monitor trends | Standard |
| **Slow** | 200ms-1s | Optimize queries, add indexes | Warning |
| **Critical** | 1-5s | Immediate optimization required | Alert |
| **Unacceptable** | > 5s | Emergency intervention | Incident |

### Database Safety Rules
| Rule | Enforcement | Scope |
|------|------------|-------|
| **Backup Before Change** | Always backup before DDL operations | All environments |
| **No Direct Production** | All changes via migration scripts | Production only |
| **Index Analysis** | Review EXPLAIN plan before deployment | All queries |
| **Connection Pooling** | Enforce connection pool limits | All environments |
| **Encryption at Rest** | Verify TDE/encryption for sensitive data | Production |

### Industry Standards Built In
| Standard | Applied To |
|----------|-----------|
| **ITIL v4** | Service management best practices |
| **ISO 20000** | IT service management standard |
| **COBIT** | IT governance and management framework |
| **TOGAF** | Enterprise architecture methodology |
| **SAFe** | Scaled agile framework for enterprise |