---
description: "Docker Security Scanner skill -- Implements container security scanning with Trivy, Snyk, and Docker Scout for vulnerability detection and compliance enforcement"
---

# Docker Security Scanner Skill

**Category:** Tech Skills > DevOps > Docker

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Docker Security Scanner operations using Docker technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Docker within DevOps development.

## When to Use

- When scanning container images for vulnerabilities
- When implementing security policies for container registries
- When enforcing compliance with container security benchmarks
- When Docker-specific technical expertise is required
- When best practices for Docker technology stack must be applied
- When production-grade Docker implementation guidance is needed

## Capabilities

- Scan images with Trivy for CVE detection
- Implement Snyk container scanning in CI/CD
- Use Docker Scout for supply chain analysis
- Enforce CIS Docker Benchmark compliance
- Configure admission policies for registry security

## Procedure

1. Choose scanning tool based on requirements
2. Integrate scanning into CI/CD pipeline
3. Configure severity thresholds for blocking
4. Implement registry scanning policies
5. Generate compliance reports
6. Remediate findings and rescan

## Output Format

Return structured results:

- **Scan Results**
- **Compliance Report**
- **Remediation Plan**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **CIS Docker Benchmark** | Container security hardening guidelines |
| **Trivy** | Comprehensive vulnerability scanner |
| **Supply Chain Security** | SBOM generation and analysis |

## Anti-Hallucination Rules

- Do not suppress vulnerability findings without documented risk acceptance
- Verify scanner database is up to date
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- No critical vulnerabilities in production images
- Scanning runs on every image build
- Compliance reports are current
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Docker community best practices

## Integration Points

- **Companion Agent**: `@docker-security-scanner` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Docker coverage |
<!-- Technology knowledge base entry for Docker Security Scanner in Docker DevOps -->
<!-- Technology knowledge base entry for Docker Security Scanner in Docker DevOps -->