# Feedback Processor -- User Guide

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
|   |   \-- feedback-processor/
|   |       \-- feedback-processor.agent.md
|   |-- skills/
|   |   \-- feedback-processor-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- feedback-processor.instructions.md
|   |-- hooks/
|   |   \-- feedback-processor-hook.json
|   |-- prompts/
|   |   \-- feedback-processor.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `FEEDBACK_PRO_MODE` | `standard` | Operation mode: quick, standard, thorough |
| `FEEDBACK_PRO_DRY_RUN` | `false` | Preview changes without executing |
| `FEEDBACK_PRO_LOG_LEVEL` | `info` | Logging level: debug, info, warn, error |
| `FEEDBACK_PRO_TIMEOUT` | `300` | Maximum execution time in seconds |
| `FEEDBACK_PRO_NOTIFY` | `true` | Send notifications on completion |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@feedback-processor`
4. Type `/` -- you should see `/feedback-processor.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@feedback-processor Create a runbook for the database failover procedure
@feedback-processor Search knowledge base for previous incidents related to memory leaks
@feedback-processor Update the onboarding guide with the new deployment process
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/feedback-processor.prompt` | Guided workflow for Feedback Processor with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@feedback-processor Use when processing user feedback on knowledge articles, updating relevance scores, or triggering knowledge reviews.
```

#### Detailed Request
```
@feedback-processor I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Feedback Processor |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@feedback-processor`) |
| **Domain** | Knowledge |
| **Description** | Use when processing user feedback on knowledge articles, updating relevance scores, or triggering knowledge reviews. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **feedback-processor-skill** | Knowledge | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Feedback Processor operations |

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
| `feedback-processor-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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