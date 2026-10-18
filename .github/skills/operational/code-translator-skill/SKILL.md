---
description: "Code Translator skill -- Use when translating legacy code to modern languages while preserving business logic and behavior."
---

# Code Translator Skill

**Category:** Tech Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Code Translator operations. This skill encapsulates technology-specific patterns, toolchain expertise, and implementation best practices.

## When to Use

- When translating legacy code to modern languages while preserving business logic and behavior
- When technology-specific patterns and toolchain expertise are required
- When automated scanning, analysis, or code generation is needed
- When integration with development tools and CI/CD pipelines is required

## Capabilities

- Configure telemetry collection across metrics, logs, and distributed traces
- Establish baseline metrics and detect anomalies using statistical analysis
- Correlate signals across multiple data sources for root cause identification
- Define and tune alert rules with severity thresholds and noise reduction
- Build monitoring dashboards with SLI visualization and drill-down capability
- Analyze log patterns for error classification and trend detection
- Configure distributed tracing for request flow analysis across services
- Generate observability reports with health status, SLI trends, and alert effectiveness

## Procedure

1. Receive monitoring request -- identify target system, metric types, and alert thresholds
2. Discover available telemetry sources: metrics endpoints, log streams, trace collectors
3. Configure data collection pipelines with appropriate sampling and aggregation
4. Establish baseline metrics for normal operating ranges and seasonal patterns
5. Define alert rules with severity levels, escalation paths, and notification channels
6. Correlate signals across metrics, logs, and traces for anomaly detection
7. Build visualization dashboards with key SLIs, trend charts, and drill-down views
8. Validate alert accuracy: check for false positives, noise reduction, and coverage gaps
9. Generate monitoring report with health status, anomalies, and recommendations

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
