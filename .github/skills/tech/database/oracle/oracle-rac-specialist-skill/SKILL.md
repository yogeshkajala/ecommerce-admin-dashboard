---
description: "Oracle RAC Specialist skill -- Configures and manages Oracle Real Application Clusters for high availability, scalability, and workload distribution"
---

# Oracle RAC Specialist Skill

**Category:** Tech Skills > Database > Oracle

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Oracle RAC Specialist operations using Oracle technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Oracle within Database development.

## When to Use

- When deploying Oracle RAC for high availability
- When managing RAC instances and cache fusion
- When optimizing RAC interconnect performance
- When Oracle-specific technical expertise is required
- When best practices for Oracle technology stack must be applied
- When production-grade Oracle implementation guidance is needed

## Capabilities

- Deploy Oracle RAC with proper ASM configuration
- Manage cache fusion and global cache
- Configure TAF for transparent application failover
- Optimize interconnect performance
- Monitor RAC health with cluster verification utility

## Procedure

1. Design RAC topology with storage configuration
2. Deploy RAC instances with ASM
3. Configure Global Cache and interconnect
4. Set up TAF policies for failover
5. Monitor with cluster health advisor
6. Test failover procedures regularly

## Output Format

Return structured results:

- **RAC Configuration**
- **ASM Setup**
- **Failover Procedures**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Oracle RAC** | RAC deployment and management |
| **ASM** | Automatic Storage Management configuration |
| **Cache Fusion** | Global cache performance optimization |

## Anti-Hallucination Rules

- Do not assume RAC eliminates all single points of failure
- Verify RAC features in target Oracle version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Cache fusion latency is within acceptable limits
- TAF policies handle failover transparently
- Interconnect bandwidth supports workload
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Oracle community best practices

## Integration Points

- **Companion Agent**: `@oracle-rac-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Oracle coverage |
<!-- Technology knowledge base entry for Oracle RAC Specialist in Oracle Database -->
<!-- Technology knowledge base entry for Oracle RAC Specialist in Oracle Database -->