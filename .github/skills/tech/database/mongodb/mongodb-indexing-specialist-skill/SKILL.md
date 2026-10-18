---
description: "MongoDB Indexing Specialist skill -- Designs MongoDB index strategies including compound indexes, text indexes, wildcard indexes, and atlas search for query optimization"
---

# MongoDB Indexing Specialist Skill

**Category:** Tech Skills > Database > MongoDB

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MongoDB Indexing Specialist operations using MongoDB technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MongoDB within Database development.

## When to Use

- When designing index strategies for MongoDB collections
- When implementing text search and geospatial indexes
- When analyzing index usage and performance impact
- When MongoDB-specific technical expertise is required
- When best practices for MongoDB technology stack must be applied
- When production-grade MongoDB implementation guidance is needed

## Capabilities

- Design compound indexes with proper field ordering
- Create text indexes for full-text search
- Implement geospatial indexes for location queries
- Use wildcard indexes for dynamic field patterns
- Monitor index usage with explain() and 

## Procedure

1. Analyze query patterns with explain()
2. Design indexes based on query selectivity
3. Create compound indexes with ESR rule
4. Monitor index usage and identify gaps
5. Remove unused indexes to reduce write overhead
6. Test index effectiveness with workload simulation

## Output Format

Return structured results:

- **Index Strategy**
- **Usage Analysis**
- **Performance Metrics**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **MongoDB Indexes** | Index type selection and design guidelines |
| **ESR Rule** | Equality, Sort, Range ordering for compound indexes |
| **Atlas Search** | Full-text search with Lucene-based indexes |

## Anti-Hallucination Rules

- Do not create indexes without analyzing actual query patterns
- Verify index type availability in target MongoDB version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All frequent queries use indexes
- Index builds do not impact production performance
- Write performance is acceptable with index overhead
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MongoDB community best practices

## Integration Points

- **Companion Agent**: `@mongodb-indexing-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MongoDB coverage |