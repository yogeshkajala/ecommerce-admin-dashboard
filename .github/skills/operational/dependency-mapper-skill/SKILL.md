---
description: "Dependency Mapper skill -- Use when mapping workload dependencies, communication patterns, and data flows to define migration groups."
---

# Dependency Mapper Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Dependency Mapper operations. This skill encapsulates technology-specific patterns, toolchain expertise, and implementation best practices.

## When to Use

- When mapping workload dependencies, communication patterns, and data flows to define migration groups
- When technology-specific patterns and toolchain expertise are required
- When automated scanning, analysis, or code generation is needed
- When integration with development tools and CI/CD pipelines is required

## Capabilities

- Execute static analysis using language-appropriate tools (ESLint, pylint, Checkstyle, Roslyn)
- Measure cyclomatic and cognitive complexity per function and module
- Detect code duplication and suggest extraction opportunities
- Identify dead code, unreachable branches, and unused dependencies
- Scan dependencies for known CVEs, license issues, and supply chain risks
- Calculate maintainability index and technical debt estimates
- Detect breaking changes and backward compatibility issues
- Generate analysis reports with findings, metrics, and remediation priorities

## Procedure

1. Receive analysis request -- identify target codebase, analysis type, and severity thresholds
2. Detect programming language, build system, and applicable analysis tools
3. Execute analysis scan with configured rule sets and thresholds
4. Parse scan results -- extract findings with file, line, severity, and description
5. Classify findings by category: bugs, security, performance, maintainability, style
6. Calculate aggregate metrics: complexity scores, duplication ratios, debt estimates
7. Map critical findings to remediation actions with effort and priority
8. Compare results against baseline to detect regressions or improvements
9. Generate analysis report with findings, metrics, trends, and recommendations

## Output Format

Return structured results:

- **Summary**: operation performed, scope, and execution status
- **Findings**: issue ID, severity, file/location, description, remediation
- **Metrics**: quantitative measurements (coverage, complexity, performance, counts)
- **Quality Gate**: PASS/FAIL with gate criteria evaluation details
- **Recommendations**: prioritized improvement actions with effort estimates

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **IEEE 730** | Software quality assurance processes and standards |
| **ISO 25010** | Software quality model: functional suitability, reliability, maintainability |

## Anti-Hallucination Rules

- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER report tool output without actual execution evidence
- ALWAYS verify version compatibility before applying technology-specific patterns

## Constraints

- NEVER execute destructive operations without explicit user confirmation
- NEVER store, log, or expose secrets, credentials, or PII in output
- ALWAYS provide evidence for assertions -- no claims without supporting data
- ALWAYS follow the principle of least privilege for tool and data access
- NEVER bypass security checks or disable safety validations
- ALWAYS use the appropriate tool version matching the target environment
