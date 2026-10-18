# Static Analyzer -- User Guide

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
| **SIEM / Log Platform** | Instance URL + API key (Splunk, Elasticsearch, Datadog) |
| **Vulnerability Scanner** | Snyk / Trivy / SonarQube API token |
| **Secrets Manager** | HashiCorp Vault / AWS Secrets Manager / Azure Key Vault credentials |
| **Alerting Platform** | API key (PagerDuty, OpsGenie) for threat escalation |

---

## How to Setup

### Step 1 -- Get the Agent
Copy the `.github` folder from this package into your workspace root directory.

Your workspace should look like:
```
your-workspace/
|-- .github/
|   |-- agents/
|   |   \-- static-analyzer/
|   |       \-- static-analyzer.agent.md
|   |-- skills/
|   |   \-- static-analyzer-skill/
|   |       \-- SKILL.md
|   |-- instructions/
|   |   \-- static-analyzer.instructions.md
|   |-- hooks/
|   |   \-- static-analyzer-hook.json
|   |-- prompts/
|   |   \-- static-analyzer.prompt.md
|   \-- copilot-instructions.md
\-- ... (your project files)
```

### Step 2 -- Configure Settings
Edit `.github/copilot-instructions.md` to customize behavior:

| Setting | Default | Description |
|---------|---------|-------------|
| `STATIC_ANALY_SCAN_DEPTH` | `full` | Scan depth: quick, standard, full, deep |
| `STATIC_ANALY_SEVERITY_THRESHOLD` | `medium` | Minimum severity to report: critical, high, medium, low |
| `STATIC_ANALY_BLOCK_ON_CRITICAL` | `true` | Block pipeline on critical findings |
| `STATIC_ANALY_INCLUDE_TRANSITIVE` | `true` | Include transitive dependency scanning |
| `STATIC_ANALY_COMPLIANCE_FRAMEWORK` | `owasp` | Framework: owasp, cis, nist, soc2, pci-dss |

### Step 3 -- Verify Agent Loading
1. Open VS Code in your workspace
2. Open Copilot Chat (Ctrl+Shift+I)
3. Type `@` -- you should see `@static-analyzer`
4. Type `/` -- you should see `/static-analyzer.prompt`

---

## How to Use

### Invoke the Agent Directly
Type `@` in the Copilot Chat input followed by the agent command:
```
@static-analyzer Scan this repository for OWASP Top 10 vulnerabilities
@static-analyzer Check all dependencies for known CVEs and license compliance issues
@static-analyzer Detect hardcoded secrets and credentials in the codebase
```

### Use Slash Command Prompts
Type `/` in the chat to access guided workflows:

| Command | Purpose |
|---------|--------|
| `/static-analyzer.prompt` | Guided workflow for Static Analyzer with step-by-step prompts |

### Example Workflows

#### Quick Start
```
@static-analyzer Use when running static analysis for cyclomatic complexity, code duplication, security vulnerabilities, dependency risks, and code coverage metrics.
```

#### Detailed Request
```
@static-analyzer I need a thorough analysis with specific recommendations and evidence-backed findings.
```

---

## Agent Details

| Field | Value |
|-------|-------|
| **Name** | Static Analyzer |
| **Type** | Specialist Agent |
| **Invocable** | Yes (`@static-analyzer`) |
| **Domain** | Security |
| **Description** | Use when running static analysis for cyclomatic complexity, code duplication, security vulnerabilities, dependency risks, and code coverage metrics. |
| **Tools** | read, search |

---

## Skill List

Skills provide domain knowledge loaded automatically when trigger conditions match.

| Skill | Domain | Key Capabilities |
|-------|--------|-----------------|
| **static-analyzer-skill** | Security | Domain-specific knowledge, procedures, best practices, validation rules, and reporting templates for Static Analyzer operations |

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
| `static-analyzer-hook` | `PostToolUse` | Validates tool outputs against domain rules before agent processing |

### Vulnerability Severity Matrix
| Severity | CVSS Score | Response SLA | Action Required |
|----------|-----------|-------------|-----------------|
| **Critical** | 9.0-10.0 | 4 hours | Immediate patch, notify security team |
| **High** | 7.0-8.9 | 24 hours | Priority patch, block deployment |
| **Medium** | 4.0-6.9 | 7 days | Schedule patch, track in backlog |
| **Low** | 0.1-3.9 | 30 days | Address in next maintenance window |
| **Info** | 0.0 | Best effort | Document for awareness |

### OWASP Top 10 Coverage
| # | Category | Detection Method | Auto-Fix |
|---|----------|-----------------|----------|
| A01 | Broken Access Control | Static analysis + config review | Partial |
| A02 | Cryptographic Failures | Secret scanning + crypto audit | Yes |
| A03 | Injection | Pattern matching + taint analysis | Partial |
| A04 | Insecure Design | Architecture review + threat model | No |
| A05 | Security Misconfiguration | Config scanning + CIS benchmarks | Yes |

### Industry Standards Built In
| Standard | Applied To |
|----------|-----------|
| **OWASP Top 10** | Web application security risks |
| **NIST CSF** | Cybersecurity framework -- identify, protect, detect, respond, recover |
| **CIS Controls** | Critical security controls for effective cyber defense |
| **SANS Top 25** | Most dangerous software weaknesses |
| **ISO 27001** | Information security management system standard |