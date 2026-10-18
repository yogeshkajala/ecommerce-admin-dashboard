---
description: "Microservice Observability Specialist skill -- Implements distributed observability for microservices with tracing, logging, and metrics correlation across service boundaries"
---

# Microservice Observability Specialist Skill

**Category:** Tech Skills > Others > Microservices

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Microservice Observability Specialist operations using Microservices technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Microservices within Others development.

## When to Use

- When implementing distributed tracing across microservices
- When correlating logs across service boundaries
- When building service-level dashboards for microservice health
- When Microservices-specific technical expertise is required
- When best practices for Microservices technology stack must be applied
- When production-grade Microservices implementation guidance is needed

## Capabilities

- Implement distributed tracing with OpenTelemetry
- Correlate logs with trace and span IDs
- Configure service-level metrics and SLIs
- Build dependency maps from tracing data
- Implement health check endpoints per service

## Procedure

1. Instrument services with OpenTelemetry
2. Configure trace and span ID propagation
3. Set up centralized log aggregation
4. Build service-level dashboards
5. Create dependency maps
6. Configure health check endpoints

## Output Format

Return structured results:

- **Tracing Configuration**
- **Log Correlation Setup**
- **Service Dashboard**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **OpenTelemetry** | Distributed observability standard |
| **Distributed Tracing** | Trace propagation across services |
| **Log Correlation** | Cross-service log correlation patterns |

## Anti-Hallucination Rules

- Do not sample all traces in production - use head-based or tail-based sampling
- Verify OpenTelemetry SDK compatibility with framework
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Traces span across all services in a request
- Logs are correlated with trace IDs
- Health checks detect service issues
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Microservices community best practices

## Integration Points

- **Companion Agent**: `@microservice-observability-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Microservices coverage |