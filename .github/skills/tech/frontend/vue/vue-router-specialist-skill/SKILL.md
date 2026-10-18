---
description: "Vue Router Specialist skill -- Configures Vue Router for complex navigation with nested routes, navigation guards, lazy loading, and typed route parameters"
---

# Vue Router Specialist Skill

**Category:** Tech Skills > Frontend > Vue

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Vue Router Specialist operations using Vue technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Vue within Frontend development.

## When to Use

- When configuring Vue Router with nested layouts and guards
- When implementing typed route parameters and query strings
- When setting up lazy-loaded routes for code splitting
- When Vue-specific technical expertise is required
- When best practices for Vue technology stack must be applied
- When production-grade Vue implementation guidance is needed

## Capabilities

- Configure nested routes with named views
- Implement navigation guards for authentication
- Set up typed route params with vue-router/auto
- Configure lazy-loaded routes with defineAsyncComponent
- Handle navigation failures and redirect chains

## Procedure

1. Analyze navigation requirements and guard needs
2. Design route hierarchy with meta fields
3. Implement navigation guards at global and per-route level
4. Configure lazy loading at route boundaries
5. Set up typed routes with auto-generation
6. Test navigation flows with router mock

## Output Format

Return structured results:

- **Route Configuration**
- **Guard Implementations**
- **Type Definitions**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Vue Router Guide** | Official routing patterns and guard lifecycle |
| **Typed Routes** | Type-safe route definitions with vue-router/auto |
| **Code Splitting** | Route-based lazy loading patterns |

## Anti-Hallucination Rules

- Do not mix Vue Router v3 and v4 APIs
- Verify navigation guard API matches the router version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All sensitive routes have proper guards
- Lazy loading boundaries optimize bundle size
- Navigation failures are handled gracefully
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Vue community best practices

## Integration Points

- **Companion Agent**: `@vue-router-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Vue coverage |
<!-- Technology knowledge base entry for Vue Router Specialist in Vue Frontend -->