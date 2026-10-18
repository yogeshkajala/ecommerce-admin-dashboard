---
description: "GraphQL Federation Specialist skill -- Implements GraphQL Federation for composing a supergraph from multiple subgraph services with Apollo Federation"
---

# GraphQL Federation Specialist Skill

**Category:** Tech Skills > Others > GraphQL

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for GraphQL Federation Specialist operations using GraphQL technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for GraphQL within Others development.

## When to Use

- When building federated GraphQL APIs across microservices
- When composing a supergraph from multiple subgraphs
- When implementing entity resolution across services
- When GraphQL-specific technical expertise is required
- When best practices for GraphQL technology stack must be applied
- When production-grade GraphQL implementation guidance is needed

## Capabilities

- Design federated schema with entities and keys
- Implement subgraph services with @key directives
- Configure Apollo Router or Gateway
- Implement entity reference resolvers
- Monitor federated graph with Apollo Studio

## Procedure

1. Design entity ownership across subgraphs
2. Implement subgraphs with federation directives
3. Configure router for composition
4. Test entity resolution across services
5. Monitor with Apollo Studio
6. Handle schema evolution with contracts

## Output Format

Return structured results:

- **Federation Design**
- **Subgraph Schemas**
- **Router Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Apollo Federation** | Federation specification and patterns |
| **Subgraph Design** | Entity ownership and key design |
| **Schema Composition** | Supergraph composition rules |

## Anti-Hallucination Rules

- Do not share entity ownership without clear boundaries
- Verify federation version compatibility across subgraphs
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Entity resolution works across services
- Schema composition succeeds without errors
- Performance meets latency requirements
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow GraphQL community best practices

## Integration Points

- **Companion Agent**: `@graphql-federation-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full GraphQL coverage |
<!-- Technology knowledge base entry for GraphQL Federation Specialist in GraphQL Others -->