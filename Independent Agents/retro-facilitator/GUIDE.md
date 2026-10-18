# Retro Facilitator -- User Guide

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
|   |   \-- retro-facilitator/
|   |       \-- retro-facilitator.agent.md
|   |-- skills/
|   |   \-- retro-facilitator-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- retro-facilitator.instructions.md
|   |-- hooks/
|   |   \-- retro-facilitator-hook.json
|   |-- prompts/
|   |   \-- retro-facilitator.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `RETRO_FACILI_FRAMEWORK` | `auto` | Test framework: jest, pytest, junit, xunit, auto-detect |
| `RETRO_FACILI_COVERAGE_MIN` | `80` | Minimum code coverage percentage threshold |
| `RETRO_FACILI_PARALLEL` | `true` | Run tests in parallel when possible |
| `RETRO_FACILI_MOCK_EXTERNAL` | `true` | Auto-mock external dependencies |
| `RETRO_FACILI_REPORT_FORMAT` | `markdown` | Report format: markdown, json, junit-xml |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@retro-facilitator`
4. Type `/` -- you should see `/retro-facilitator.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@retro-facilitator Run unit tests for the auth module with 90% coverage target
@retro-facilitator Generate integration tests for the payment API endpoints
@retro-facilitator Analyze test coverage gaps in src/services/ and generate missing tests
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/retro-facilitator.prompt` | Guided workflow for Retro Facilitator with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@retro-facilitator Facilitate retrospectives: gather feedback, identify actions, track improvements.
```

#### Detailed Request
```
@retro-facilitator I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Retro Facilitator |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@retro-facilitator`) |
| **Domain** | Testing |
| **Description** | Facilitate retrospectives: gather feedback, identify actions, track improvements. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **retro-facilitator-skill** | Testing | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Retro Facilitator operations |

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
| `retro-facilitator-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

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