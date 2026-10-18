---
description: "Redis Data Structure Specialist skill -- Leverages Redis data structures including sorted sets, HyperLogLog, bitmaps, and geospatial indexes for efficient data operations"
---

# Redis Data Structure Specialist Skill

**Category:** Tech Skills > Database > Redis

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Redis Data Structure Specialist operations using Redis technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Redis within Database development.

## When to Use

- When implementing leaderboards with sorted sets
- When using HyperLogLog for cardinality estimation
- When building geospatial queries with Redis GEO commands
- When Redis-specific technical expertise is required
- When best practices for Redis technology stack must be applied
- When production-grade Redis implementation guidance is needed

## Capabilities

- Design sorted sets for ranking and scoring
- Implement HyperLogLog for unique count estimation
- Use bitmaps for efficient flag storage
- Build geospatial indexes with GEOADD and GEORADIUS
- Combine data structures for complex operations

## Procedure

1. Analyze data requirements and operations
2. Choose appropriate Redis data structure
3. Implement operations with proper commands
4. Configure memory optimization for data type
5. Test with representative data volumes
6. Monitor memory usage per data structure

## Output Format

Return structured results:

- **Data Structure Design**
- **Command Patterns**
- **Memory Analysis**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Redis Data Types** | Data structure selection and usage patterns |
| **Sorted Sets** | Ranking and range query operations |
| **Geospatial** | Location-based query capabilities |

## Anti-Hallucination Rules

- Do not use strings where specialized data structures are more efficient
- Verify data structure features in target Redis version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Data structures match access patterns
- Memory usage is optimized for the data type
- Operations complete within latency targets
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Redis community best practices

## Integration Points

- **Companion Agent**: `@redis-data-structure-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Redis coverage |
<!-- Technology knowledge base entry for Redis Data Structure Specialist in Redis Database -->