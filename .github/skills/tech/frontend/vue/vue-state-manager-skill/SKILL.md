---
description: "Vue State Manager skill -- Implements state management in Vue applications using Pinia, Vuex, or composable patterns for scalable reactive state"
---

# Vue State Manager Skill

**Category:** Tech Skills > Frontend > Vue

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Vue State Manager operations using Vue technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Vue within Frontend development.

## When to Use

- When implementing centralized state management with Pinia
- When migrating from Vuex to Pinia store patterns
- When building composable-based state management solutions
- When Vue-specific technical expertise is required
- When best practices for Vue technology stack must be applied
- When production-grade Vue implementation guidance is needed

## Capabilities

- Create Pinia stores with state, getters, and actions
- Implement store composition and cross-store references
- Build composable-based state with reactive and ref
- Configure Pinia plugins for persistence and devtools
- Optimize state subscriptions and computed properties

## Procedure

1. Assess state management needs and complexity
2. Design store architecture with proper boundaries
3. Implement Pinia stores with TypeScript
4. Configure plugins for persistence and logging
5. Set up devtools integration for debugging
6. Test stores independently with Pinia testing utilities

## Output Format

Return structured results:

- **Store Architecture**
- **Pinia Implementation**
- **Plugin Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Pinia Guide** | Official Pinia patterns for Vue 3 state management |
| **Composables** | Reactive composable patterns for shared state |
| **Store Design** | Store decomposition and composition patterns |

## Anti-Hallucination Rules

- Do not use Vuex API patterns in Pinia stores
- Verify Pinia version compatibility with Vue version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Stores follow single responsibility principle
- Getters are used for derived state
- Actions handle async operations properly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Vue community best practices

## Integration Points

- **Companion Agent**: `@vue-state-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Vue coverage |
<!-- Technology knowledge base entry for Vue State Manager in Vue Frontend -->