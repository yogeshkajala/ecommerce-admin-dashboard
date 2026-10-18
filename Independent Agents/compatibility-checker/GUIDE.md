# Compatibility Checker -- User Guide

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
|   |   \-- compatibility-checker/
|   |       \-- compatibility-checker.agent.md
|   |-- skills/
|   |   \-- compatibility-checker-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- compatibility-checker.instructions.md
|   |-- hooks/
|   |   \-- compatibility-checker-hook.json
|   |-- prompts/
|   |   \-- compatibility-checker.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `COMPATIBILIT_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `COMPATIBILIT_DRY_RUN` | `false` | Preview changes without executing |
| `COMPATIBILIT_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `COMPATIBILIT_TIMEOUT` | `300` | Maximum execution time in seconds |
| `COMPATIBILIT_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@compatibility-checker`
4. Type `/` -- you should see `/compatibility-checker.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@compatibility-checker Optimize slow queries in the orders table taking over 2 seconds
@compatibility-checker Plan database migration from PostgreSQL 13 to PostgreSQL 16
@compatibility-checker Analyze index usage and recommend improvements for the users database
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/compatibility-checker.prompt` | Guided workflow for Compatibility Checker with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@compatibility-checker Use when checking workload compatibility with target cloud platform including OS, runtime, database, and service compatibility.
```

#### Detailed Request
```
@compatibility-checker I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Compatibility Checker |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@compatibility-checker`) |
| **Domain** | Database |
| **Description** | Use when checking workload compatibility with target cloud platform including OS, runtime, database, and service compatibility. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **compatibility-checker-skill** | Database | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Compatibility Checker operations |

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
| `compatibility-checker-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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