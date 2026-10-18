---
description: "Svelte Store Manager skill -- Implements state management in Svelte applications using writable, readable, and derived stores with custom store patterns"
---

# Svelte Store Manager Skill

**Category:** Tech Skills > Frontend > Svelte

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Svelte Store Manager operations using Svelte technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Svelte within Frontend development.

## When to Use

- When implementing shared state with Svelte stores
- When building custom stores with subscription logic
- When migrating to Svelte 5 runes-based state management
- When Svelte-specific technical expertise is required
- When best practices for Svelte technology stack must be applied
- When production-grade Svelte implementation guidance is needed

## Capabilities

- Create writable, readable, and derived stores
- Build custom stores with start/stop logic
- Implement store contracts for cross-component state
- Design persistent stores with localStorage integration
- Handle store subscriptions and auto-unsubscription

## Procedure

1. Assess state sharing requirements
2. Design store architecture with proper granularity
3. Implement stores with appropriate writability
4. Add derived stores for computed values
5. Configure store persistence if needed
6. Test stores with subscription assertions

## Output Format

Return structured results:

- **Store Implementation**
- **Subscription Patterns**
- **Persistence Config**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Svelte Stores** | Official store contract and built-in stores |
| **Store Patterns** | Custom store patterns for complex state |
| **Auto-subscription** | $-prefix auto-subscription in components |

## Anti-Hallucination Rules

- Do not assume $-prefix syntax works outside Svelte components
- Verify store API changes in Svelte 5 with runes
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Stores follow the Svelte store contract
- Subscriptions are properly cleaned up
- Derived stores update efficiently
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Svelte community best practices

## Integration Points

- **Companion Agent**: `@svelte-store-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Svelte coverage |
<!-- Technology knowledge base entry for Svelte Store Manager in Svelte Frontend -->