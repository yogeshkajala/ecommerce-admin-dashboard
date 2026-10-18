---
description: "REST API Pagination Specialist skill -- Implements API pagination with offset, cursor, and keyset strategies with proper response formatting and link headers"
---

# REST API Pagination Specialist Skill

**Category:** Tech Skills > Others > REST API

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for REST API Pagination Specialist operations using REST API technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for REST API within Others development.

## When to Use

- When implementing pagination for large result sets
- When choosing between offset and cursor pagination
- When designing paginated response formats
- When REST API-specific technical expertise is required
- When best practices for REST API technology stack must be applied
- When production-grade REST API implementation guidance is needed

## Capabilities

- Implement offset-based pagination
- Design cursor-based pagination for consistency
- Implement keyset pagination for performance
- Configure response with pagination metadata
- Add Link headers for navigation

## Procedure

1. Analyze pagination requirements
2. Choose pagination strategy
3. Implement pagination logic
4. Add pagination metadata to responses
5. Include navigation links
6. Test with large datasets

## Output Format

Return structured results:

- **Pagination Implementation**
- **Response Format**
- **Navigation Links**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Cursor Pagination** | Cursor-based pagination patterns |
| **Offset Pagination** | Offset and limit pagination patterns |
| **RFC 8288** | Web Linking for pagination |

## Anti-Hallucination Rules

- Do not use offset pagination for rapidly changing datasets
- Verify pagination performance with large datasets
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Pagination handles large datasets efficiently
- Response includes proper navigation
- No duplicate or missing items across pages
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow REST API community best practices

## Integration Points

- **Companion Agent**: `@rest-api-pagination-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full REST API coverage |
<!-- Technology knowledge base entry for REST API Pagination Specialist in REST API Others -->
<!-- Technology knowledge base entry for REST API Pagination Specialist in REST API Others -->