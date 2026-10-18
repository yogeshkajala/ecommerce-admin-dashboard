# Retrospective Facilitator -- User Guide

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
| **Test Platform** | Jest/pytest/JUnit CLI, Selenium Grid URL, BrowserStack API key |
| **Coverage Tool** | Istanbul/Coverage.py/JaCoCo endpoint for coverage reporting |
| **CI/CD** | Jenkins/GitHub Actions/Azure DevOps API token for pipeline integration |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- retrospective-facilitator/
|   |       \-- retrospective-facilitator.agent.md
|   |-- skills/
|   |   \-- retrospective-facilitator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- retrospective-facilitator.instructions.md
|   |-- hooks/
|   |   \-- retrospective-facilitator-hook.json
|   |-- prompts/
|   |   \-- retrospective-facilitator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `RETROSPECTIV_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `RETROSPECTIV_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `RETROSPECTIV_PARALLEL` | `true` | Run tests in parallel when possible |
| `RETROSPECTIV_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `RETROSPECTIV_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@retrospective-facilitator`
4. Type `/` -- you should see `/retrospective-facilitator.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@retrospective-facilitator Run unit tests for the auth module with 90% coverage target
@retrospective-facilitator Generate integration tests for the payment API endpoints
@retrospective-facilitator Analyze test coverage gaps in src/services/ and generate missing tests
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/retrospective-facilitator.prompt` | Guided workflow for Retrospective Facilitator with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@retrospective-facilitator Use when facilitating sprint retrospectives with structured what-went-well, what-to-improve, and action item tracking.
```

#### Detailed Request
```
@retrospective-facilitator I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Retrospective Facilitator |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@retrospective-facilitator`) |
| **Domain** | Testing |
| **Description** | Use when facilitating sprint retrospectives with structured what-went-well, what-to-improve, and action item tracking. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **retrospective-facilitator-skill** | Testing | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Retrospective Facilitator operations |

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
| `retrospective-facilitator-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

### Quality Gates
| Gate | Threshold | Action on Failure |
|------|-----------|------------------|
| **Line Coverage** | >= 80% | Block merge, report gaps |
| **Branch Coverage** | >= 70% | Warn, suggest missing branches |
| **Mutation Score** | >= 60% | Report surviving mutants |
| **Test Duration** | < 5 min (unit) | Flag slow tests for optimization |
| **Flaky Rate** | < 2% | Quarantine and investigate |

### Test Generation Patterns
| Pattern | When Applied | Benefit |
|---------|-------------|---------|
| **Arrange-Act-Assert** | All unit tests | Clear test structure |
| **Given-When-Then** | BDD/acceptance tests | Business-readable tests |
| **Builder Pattern** | Complex test data | Maintainable fixtures |
| **Page Object Model** | UI/E2E tests | Reusable page interactions |
| **Contract Testing** | API integration | Service boundary validation |

### Industry Standards Built In
| Standard | Applied To |
|----------|-----------|
| **ISTQB** | Test design techniques, test levels, test types |
| **ISO 25010** | Software quality model -- functional suitability, reliability, usability |
| **IEEE 829** | Test documentation standard -- test plans, reports, logs |
| **TDD/BDD** | Test-driven and behavior-driven development practices |
| **Shift-Left** | Early testing in development lifecycle |