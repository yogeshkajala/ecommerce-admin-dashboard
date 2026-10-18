---
description: "Docker Network Specialist skill -- Configures Docker networking with bridge, overlay, and macvlan networks for container communication and isolation"
---

# Docker Network Specialist Skill

**Category:** Tech Skills > DevOps > Docker

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Docker Network Specialist operations using Docker technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Docker within DevOps development.

## When to Use

- When designing Docker network topologies for microservices
- When implementing network isolation between container groups
- When configuring overlay networks for Swarm or multi-host
- When Docker-specific technical expertise is required
- When best practices for Docker technology stack must be applied
- When production-grade Docker implementation guidance is needed

## Capabilities

- Configure bridge networks for single-host isolation
- Create overlay networks for multi-host communication
- Implement macvlan for direct network attachment
- Set up DNS-based service discovery
- Configure network policies for security

## Procedure

1. Analyze network requirements and isolation needs
2. Design network topology with proper segmentation
3. Create networks with appropriate drivers
4. Configure DNS and service discovery
5. Implement network security policies
6. Test connectivity and isolation

## Output Format

Return structured results:

- **Network Design**
- **Configuration**
- **Security Policies**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Docker Networking** | Network driver selection and configuration |
| **Network Isolation** | Container network segmentation patterns |
| **DNS Resolution** | Embedded DNS for service discovery |

## Anti-Hallucination Rules

- Do not expose container ports unnecessarily
- Verify network driver availability in Docker version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Containers can only reach intended services
- DNS resolution works for service discovery
- Network policies enforce isolation
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Docker community best practices

## Integration Points

- **Companion Agent**: `@docker-network-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Docker coverage |
<!-- Technology knowledge base entry for Docker Network Specialist in Docker DevOps -->