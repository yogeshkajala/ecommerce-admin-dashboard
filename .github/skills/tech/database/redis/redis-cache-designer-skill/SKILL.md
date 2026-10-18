---
description: "Redis Cache Designer skill -- Designs caching strategies with Redis including cache patterns, eviction policies, and TTL management for application performance"
---

# Redis Cache Designer Skill

**Category:** Tech Skills > Database > Redis

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Redis Cache Designer operations using Redis technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Redis within Database development.

## When to Use

- When implementing application caching with Redis
- When designing cache invalidation strategies
- When configuring eviction policies for memory management
- When Redis-specific technical expertise is required
- When best practices for Redis technology stack must be applied
- When production-grade Redis implementation guidance is needed

## Capabilities

- Design cache-aside, write-through, write-behind patterns
- Configure TTL strategies for different data types
- Implement cache warming and pre-loading
- Set up eviction policies: LRU, LFU, volatile
- Monitor cache hit rates and memory usage

## Procedure

1. Analyze caching requirements and data patterns
2. Choose appropriate caching pattern
3. Design key naming conventions and TTLs
4. Configure eviction policy based on workload
5. Implement cache monitoring
6. Test cache behavior under load

## Output Format

Return structured results:

- **Cache Architecture**
- **Key Design**
- **Eviction Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Caching Patterns** | Cache-aside, write-through pattern selection |
| **Eviction Policies** | LRU, LFU, and volatile key eviction |
| **Redis Memory** | Memory optimization and maxmemory configuration |

## Anti-Hallucination Rules

- Do not assume cache will always have data - handle cache misses
- Verify Redis version features for eviction policies
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Cache hit rate meets performance targets
- Eviction policy prevents OOM errors
- TTLs match data freshness requirements
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Redis community best practices

## Integration Points

- **Companion Agent**: `@redis-cache-designer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Redis coverage |
<!-- Technology knowledge base entry for Redis Cache Designer in Redis Database -->
<!-- Technology knowledge base entry for Redis Cache Designer in Redis Database -->