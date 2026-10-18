# Data Replicator -- User Guide

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
|   |   \-- data-replicator/
|   |       \-- data-replicator.agent.md
|   |-- skills/
|   |   \-- data-replicator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- data-replicator.instructions.md
|   |-- hooks/
|   |   \-- data-replicator-hook.json
|   |-- prompts/
|   |   \-- data-replicator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `DATA_REPLICA_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `DATA_REPLICA_DRY_RUN` | `false` | Preview changes without executing |
| `DATA_REPLICA_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `DATA_REPLICA_TIMEOUT` | `300` | Maximum execution time in seconds |
| `DATA_REPLICA_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@data-replicator`
4. Type `/` -- you should see `/data-replicator.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@data-replicator Optimize slow queries in the orders table taking over 2 seconds
@data-replicator Plan database migration from PostgreSQL 13 to PostgreSQL 16
@data-replicator Analyze index usage and recommend improvements for the users database
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/data-replicator.prompt` | Guided workflow for Data Replicator with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@data-replicator Replicate data to cloud with continuous sync until cutover: DMS, logical replication.
```

#### Detailed Request
```
@data-replicator I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Data Replicator |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@data-replicator`) |
| **Domain** | Database |
| **Description** | Replicate data to cloud with continuous sync until cutover: DMS, logical replication. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **data-replicator-skill** | Database | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Data Replicator operations |

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
| `data-replicator-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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