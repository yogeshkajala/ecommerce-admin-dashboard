---
description: "MongoDB Schema Designer skill -- Designs MongoDB document schemas with proper embedding, referencing, and polymorphism patterns for scalable NoSQL data modeling"
---

# MongoDB Schema Designer Skill

**Category:** Tech Skills > Database > MongoDB

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for MongoDB Schema Designer operations using MongoDB technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for MongoDB within Database development.

## When to Use

- When designing document schemas for MongoDB collections
- When choosing between embedding and referencing patterns
- When implementing polymorphic schemas for varied document types
- When MongoDB-specific technical expertise is required
- When best practices for MongoDB technology stack must be applied
- When production-grade MongoDB implementation guidance is needed

## Capabilities

- Design embedded documents for one-to-few relationships
- Implement reference patterns for one-to-many relationships
- Create polymorphic schemas with discriminator fields
- Design bucket patterns for time-series data
- Apply schema validation with JSON Schema

## Procedure

1. Analyze access patterns and query requirements
2. Design document structure with proper nesting
3. Choose embedding vs referencing for relationships
4. Apply schema validation rules
5. Test schema with representative workloads
6. Document schema conventions and patterns

## Output Format

Return structured results:

- **Schema Design**
- **Validation Rules**
- **Access Pattern Analysis**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **MongoDB Data Modeling** | Official schema design patterns and anti-patterns |
| **Schema Patterns** | Bucket, outlier, and computed patterns |
| **JSON Schema** | Document validation with JSON Schema |

## Anti-Hallucination Rules

- Do not assume relational normalization patterns apply to MongoDB
- Verify schema validation features in target MongoDB version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Schema supports all identified access patterns
- Document sizes stay within 16MB limit
- Validation rules prevent invalid documents
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow MongoDB community best practices

## Integration Points

- **Companion Agent**: `@mongodb-schema-designer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full MongoDB coverage |