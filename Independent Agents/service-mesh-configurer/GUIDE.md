# Service Mesh Configurer -- User Guide

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
|   |   \-- service-mesh-configurer/
|   |       \-- service-mesh-configurer.agent.md
|   |-- skills/
|   |   \-- service-mesh-configurer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- service-mesh-configurer.instructions.md
|   |-- hooks/
|   |   \-- service-mesh-configurer-hook.json
|   |-- prompts/
|   |   \-- service-mesh-configurer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `SERVICE_MESH_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `SERVICE_MESH_DRY_RUN` | `false` | Preview changes without executing |
| `SERVICE_MESH_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `SERVICE_MESH_TIMEOUT` | `300` | Maximum execution time in seconds |
| `SERVICE_MESH_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@service-mesh-configurer`
4. Type `/` -- you should see `/service-mesh-configurer.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@service-mesh-configurer Assess the legacy monolith for microservice migration readiness
@service-mesh-configurer Plan incremental migration of the user module from .NET 4.8 to .NET 8
@service-mesh-configurer Analyze database schema compatibility for PostgreSQL to Aurora migration
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/service-mesh-configurer.prompt` | Guided workflow for Service Mesh Configurer with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@service-mesh-configurer Use when configuring service mesh for modernized applications including traffic management, mTLS, and observability.
```

#### Detailed Request
```
@service-mesh-configurer I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Service Mesh Configurer |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@service-mesh-configurer`) |
| **Domain** | Migration |
| **Description** | Use when configuring service mesh for modernized applications including traffic management, mTLS, and observability. |
| **Tools** | read, search, edit, runCommands |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **service-mesh-configurer-skill** | Migration | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Service Mesh Configurer operations |

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
| `service-mesh-configurer-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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