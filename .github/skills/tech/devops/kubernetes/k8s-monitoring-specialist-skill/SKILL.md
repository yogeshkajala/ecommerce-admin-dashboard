---
description: "K8s Monitoring Specialist skill -- Implements Kubernetes monitoring with Prometheus, Grafana, and metrics-server for cluster and application observability"
---

# K8s Monitoring Specialist Skill

**Category:** Tech Skills > DevOps > Kubernetes

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for K8s Monitoring Specialist operations using Kubernetes technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kubernetes within DevOps development.

## When to Use

- When deploying Prometheus monitoring stack for Kubernetes
- When building Grafana dashboards for cluster observability
- When configuring alerts for cluster and application metrics
- When Kubernetes-specific technical expertise is required
- When best practices for Kubernetes technology stack must be applied
- When production-grade Kubernetes implementation guidance is needed

## Capabilities

- Deploy Prometheus with kube-prometheus-stack
- Configure ServiceMonitors for application metrics
- Build Grafana dashboards for cluster visibility
- Set up AlertManager with proper routing
- Implement custom metrics with metrics-server

## Procedure

1. Deploy monitoring stack with Helm
2. Configure service discovery for metric targets
3. Build dashboards for cluster and application metrics
4. Set up alerting rules and notification channels
5. Configure metric retention and storage
6. Test alerts with simulation

## Output Format

Return structured results:

- **Monitoring Stack**
- **Dashboard Configuration**
- **Alert Rules**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Prometheus** | Metric collection and alerting patterns |
| **Grafana** | Dashboard design and visualization |
| **kube-prometheus** | Production monitoring stack for Kubernetes |

## Anti-Hallucination Rules

- Do not configure alerts without proper notification channels
- Verify monitoring stack compatibility with cluster version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All critical metrics are collected
- Alerts fire for known failure scenarios
- Dashboards provide actionable visibility
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kubernetes community best practices

## Integration Points

- **Companion Agent**: `@k8s-monitoring-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kubernetes coverage |
<!-- Technology knowledge base entry for K8s Monitoring Specialist in Kubernetes DevOps -->