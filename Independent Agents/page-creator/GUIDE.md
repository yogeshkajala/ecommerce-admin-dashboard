# Page Creator -- User Guide

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
| **Knowledge Base** | Confluence / SharePoint / Wiki API token |
| **Search Platform** | Elasticsearch / Algolia API credentials |
| **Document Store** | S3 / Azure Blob / GCS for document storage |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- page-creator/
|   |       \-- page-creator.agent.md
|   |-- skills/
|   |   \-- page-creator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- page-creator.instructions.md
|   |-- hooks/
|   |   \-- page-creator-hook.json
|   |-- prompts/
|   |   \-- page-creator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `PAGE_CREATOR_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `PAGE_CREATOR_DRY_RUN` | `false` | Preview changes without executing |
| `PAGE_CREATOR_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `PAGE_CREATOR_TIMEOUT` | `300` | Maximum execution time in seconds |
| `PAGE_CREATOR_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@page-creator`
4. Type `/` -- you should see `/page-creator.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@page-creator Create a runbook for the database failover procedure
@page-creator Search knowledge base for previous incidents related to memory leaks
@page-creator Update the onboarding guide with the new deployment process
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/page-creator.prompt` | Guided workflow for Page Creator with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@page-creator Use when creating or updating Confluence wiki pages with structured content, macros, and attachments.
```

#### Detailed Request
```
@page-creator I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Page Creator |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@page-creator`) |
| **Domain** | Knowledge |
| **Description** | Use when creating or updating Confluence wiki pages with structured content, macros, and attachments. |
| **Tools** | read, search, edit, com.atlassian/atlassian-mcp-server/* |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **page-creator-skill** | Knowledge | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Page Creator operations |

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
| `page-creator-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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