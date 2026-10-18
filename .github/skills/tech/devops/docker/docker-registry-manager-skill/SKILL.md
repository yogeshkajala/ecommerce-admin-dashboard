---
description: "Docker Registry Manager skill -- Manages Docker registries including Harbor, ECR, and ACR with image lifecycle policies, security scanning, and access control"
---

# Docker Registry Manager Skill

**Category:** Tech Skills > DevOps > Docker

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Docker Registry Manager operations using Docker technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Docker within DevOps development.

## When to Use

- When setting up private Docker registries
- When configuring image lifecycle and retention policies
- When managing registry access control and security
- When Docker-specific technical expertise is required
- When best practices for Docker technology stack must be applied
- When production-grade Docker implementation guidance is needed

## Capabilities

- Deploy Harbor for private registry management
- Configure ECR and ACR lifecycle policies
- Set up image signing with cosign
- Implement role-based access control
- Configure garbage collection for storage management

## Procedure

1. Choose registry solution based on requirements
2. Deploy and configure registry
3. Set up access control and authentication
4. Configure lifecycle policies for image retention
5. Enable vulnerability scanning
6. Implement garbage collection schedule

## Output Format

Return structured results:

- **Registry Configuration**
- **Lifecycle Policies**
- **Access Control**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **OCI Distribution** | Container registry specification |
| **Image Signing** | Supply chain security with cosign |
| **RBAC** | Registry access control patterns |

## Anti-Hallucination Rules

- Do not store credentials in image layers
- Verify registry compatibility with container runtime
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Access control prevents unauthorized image push/pull
- Lifecycle policies prevent storage bloat
- Image signing is enforced for production
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Docker community best practices

## Integration Points

- **Companion Agent**: `@docker-registry-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Docker coverage |
<!-- Technology knowledge base entry for Docker Registry Manager in Docker DevOps -->
<!-- Technology knowledge base entry for Docker Registry Manager in Docker DevOps -->