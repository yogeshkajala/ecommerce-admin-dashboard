---
description: "Nginx Performance Tuner skill -- Optimizes Nginx performance with worker processes, connection handling, caching, and compression for high-throughput delivery"
---

# Nginx Performance Tuner Skill

**Category:** Tech Skills > Others > Nginx

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Nginx Performance Tuner operations using Nginx technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Nginx within Others development.

## When to Use

- When tuning Nginx for high traffic performance
- When configuring caching for static and dynamic content
- When implementing compression for bandwidth optimization
- When Nginx-specific technical expertise is required
- When best practices for Nginx technology stack must be applied
- When production-grade Nginx implementation guidance is needed

## Capabilities

- Tune worker processes and connections
- Configure proxy and static file caching
- Implement gzip and Brotli compression
- Optimize buffer sizes for response handling
- Configure rate limiting for traffic control

## Procedure

1. Analyze traffic patterns and requirements
2. Tune worker and connection settings
3. Configure caching for appropriate content
4. Enable compression for text content
5. Optimize buffer and timeout settings
6. Load test to validate configuration

## Output Format

Return structured results:

- **Performance Configuration**
- **Cache Strategy**
- **Compression Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Nginx Performance** | Performance tuning guidelines |
| **Caching** | Proxy and static content caching |
| **Compression** | gzip and Brotli configuration |

## Anti-Hallucination Rules

- Do not increase worker connections beyond OS limits
- Verify performance features in Nginx version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Throughput meets requirements
- Caching reduces upstream load
- Compression reduces bandwidth usage
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Nginx community best practices

## Integration Points

- **Companion Agent**: `@nginx-performance-tuner` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Nginx coverage |
<!-- Technology knowledge base entry for Nginx Performance Tuner in Nginx Others -->
<!-- Technology knowledge base entry for Nginx Performance Tuner in Nginx Others -->
<!-- Technology knowledge base entry for Nginx Performance Tuner in Nginx Others -->