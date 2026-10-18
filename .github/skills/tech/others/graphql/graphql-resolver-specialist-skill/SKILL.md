---
description: "GraphQL Resolver Specialist skill -- Implements GraphQL resolvers with proper data loading, N+1 prevention with DataLoader, and error handling patterns"
---

# GraphQL Resolver Specialist Skill

**Category:** Tech Skills > Others > GraphQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for GraphQL Resolver Specialist operations using GraphQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for GraphQL within Others development.

## When to Use

- When implementing resolvers for GraphQL operations
- When preventing N+1 queries with DataLoader
- When handling errors and validation in resolvers
- When GraphQL-specific technical expertise is required
- When best practices for GraphQL technology stack must be applied
- When production-grade GraphQL implementation guidance is needed

## Capabilities

- Implement field-level and type-level resolvers
- Prevent N+1 with DataLoader batching
- Handle authentication and authorization in resolvers
- Implement input validation and error handling
- Design resolver composition patterns

## Procedure

1. Map resolvers to schema operations
2. Implement DataLoader for batch loading
3. Add authentication checks in resolvers
4. Implement input validation
5. Add proper error handling and formatting
6. Test resolvers with unit and integration tests

## Output Format

Return structured results:

- **Resolver Implementation**
- **DataLoader Config**
- **Error Handling**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Resolvers** | Resolver implementation patterns |
| **DataLoader** | Batching and caching for N+1 prevention |
| **Error Handling** | GraphQL error specification and formatting |

## Anti-Hallucination Rules

- Do not fetch data in parent resolvers that child resolvers will also fetch
- Verify DataLoader compatibility with framework
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- N+1 queries are eliminated
- Errors follow GraphQL error spec
- Authorization checks are consistent
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow GraphQL community best practices

## Integration Points

- **Companion Agent**: `@graphql-resolver-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full GraphQL coverage |
<!-- Technology knowledge base entry for GraphQL Resolver Specialist in GraphQL Others -->
<!-- Technology knowledge base entry for GraphQL Resolver Specialist in GraphQL Others -->