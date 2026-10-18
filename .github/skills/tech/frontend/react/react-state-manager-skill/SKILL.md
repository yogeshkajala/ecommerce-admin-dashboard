---
description: "React State Manager skill -- Implements state management solutions in React using Context, Redux Toolkit, Zustand, or Jotai for scalable application state"
---

# React State Manager Skill

**Category:** Tech Skills > Frontend > React

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for React State Manager operations using React technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for React within Frontend development.

## When to Use

- When choosing and implementing state management for React apps
- When migrating between state management solutions
- When optimizing state updates to prevent unnecessary re-renders
- When React-specific technical expertise is required
- When best practices for React technology stack must be applied
- When production-grade React implementation guidance is needed

## Capabilities

- Implement Redux Toolkit with slices and thunks
- Design context-based state with provider patterns
- Build Zustand stores with middleware and devtools
- Create Jotai atoms for fine-grained reactivity
- Optimize state subscriptions to minimize re-renders

## Procedure

1. Assess state management requirements and complexity
2. Choose appropriate state management library
3. Design state shape and update patterns
4. Implement stores/slices/atoms with proper typing
5. Configure middleware and devtools
6. Test state logic independently

## Output Format

Return structured results:

- **State Architecture**
- **Store Implementation**
- **Middleware Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Redux Toolkit** | Official Redux patterns with RTK Query and slices |
| **State Colocation** | Keep state as close to usage as possible |
| **Immutability** | Immutable state update patterns |

## Anti-Hallucination Rules

- Do not assume library API compatibility without version check
- Verify middleware compatibility with the chosen library version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- State updates are immutable
- Selectors minimize re-renders
- Error states are properly handled
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow React community best practices

## Integration Points

- **Companion Agent**: `@react-state-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full React coverage |
<!-- Technology knowledge base entry for React State Manager in React Frontend -->