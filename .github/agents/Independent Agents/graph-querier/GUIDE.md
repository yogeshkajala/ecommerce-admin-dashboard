# Graph Querier -- User Guide

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
|   |   \-- graph-querier/
|   |       \-- graph-querier.agent.md
|   |-- skills/
|   |   \-- graph-querier-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- graph-querier.instructions.md
|   |-- hooks/
|   |   \-- graph-querier-hook.json
|   |-- prompts/
|   |   \-- graph-querier.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `GRAPH_QUERIE_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `GRAPH_QUERIE_DRY_RUN` | `false` | Preview changes without executing |
| `GRAPH_QUERIE_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `GRAPH_QUERIE_TIMEOUT` | `300` | Maximum execution time in seconds |
| `GRAPH_QUERIE_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@graph-querier`
4. Type `/` -- you should see `/graph-querier.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@graph-querier Optimize slow queries in the orders table taking over 2 seconds
@graph-querier Plan database migration from PostgreSQL 13 to PostgreSQL 16
@graph-querier Analyze index usage and recommend improvements for the users database
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/graph-querier.prompt` | Guided workflow for Graph Querier with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@graph-querier Query the operational knowledge graph for dependency analysis, impact assessment, path finding, and operational insights.
```

#### Detailed Request
```
@graph-querier I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Graph Querier |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@graph-querier`) |
| **Domain** | Database |
| **Description** | Query the operational knowledge graph for dependency analysis, impact assessment, path finding, and operational insights. |
| **Tools** | read, search, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **graph-querier-skill** | Database | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Graph Querier operations |

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
| `graph-querier-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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