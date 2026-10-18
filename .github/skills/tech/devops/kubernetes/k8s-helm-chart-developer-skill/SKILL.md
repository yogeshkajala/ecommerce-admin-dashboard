---
description: "K8s Helm Chart Developer skill -- Creates and manages Helm charts for Kubernetes application packaging with templating, dependencies, and chart testing"
---

# K8s Helm Chart Developer Skill

**Category:** Tech Skills > DevOps > Kubernetes

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for K8s Helm Chart Developer operations using Kubernetes technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Kubernetes within DevOps development.

## When to Use

- When packaging Kubernetes applications with Helm charts
- When creating reusable chart templates with proper values
- When managing chart dependencies and versioning
- When Kubernetes-specific technical expertise is required
- When best practices for Kubernetes technology stack must be applied
- When production-grade Kubernetes implementation guidance is needed

## Capabilities

- Create Helm charts with proper template structure
- Implement values.yaml with sensible defaults
- Manage chart dependencies with requirements
- Create chart tests for validation
- Publish charts to Helm repositories

## Procedure

1. Design chart structure with templates
2. Implement values with proper defaults and overrides
3. Add named templates for reuse
4. Configure dependencies and subcharts
5. Write chart tests with helm test
6. Package and publish to repository

## Output Format

Return structured results:

- **Helm Chart**
- **Values Schema**
- **Test Suite**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Helm Best Practices** | Chart development guidelines and conventions |
| **Chart Templates** | Go template patterns for Helm charts |
| **Chart Repository** | Chart publishing and distribution |

## Anti-Hallucination Rules

- Do not hardcode values in templates - use values.yaml
- Verify Helm version compatibility with chart apiVersion
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Chart installs successfully with default values
- Values are properly documented
- Chart tests validate deployment
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Kubernetes community best practices

## Integration Points

- **Companion Agent**: `@k8s-helm-chart-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Kubernetes coverage |
<!-- Technology knowledge base entry for K8s Helm Chart Developer in Kubernetes DevOps -->
<!-- Technology knowledge base entry for K8s Helm Chart Developer in Kubernetes DevOps -->