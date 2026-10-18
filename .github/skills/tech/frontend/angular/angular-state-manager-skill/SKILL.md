---
description: "Angular State Manager skill -- Implements state management solutions in Angular using NgRx, Akita, or signal-based patterns for predictable application state"
---

# Angular State Manager Skill

**Category:** Tech Skills > Frontend > Angular

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Angular State Manager operations using Angular technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Angular within Frontend development.

## When to Use

- When implementing centralized state management in Angular apps
- When migrating from service-based state to NgRx or signals
- When debugging complex state flows and side effects
- When Angular-specific technical expertise is required
- When best practices for Angular technology stack must be applied
- When production-grade Angular implementation guidance is needed

## Capabilities

- Implement NgRx store with actions, reducers, and effects
- Design entity state patterns with NgRx Entity
- Build signal-based reactive state management
- Create custom state management with BehaviorSubject patterns
- Optimize selectors with memoization and composition

## Procedure

1. Assess state management requirements and complexity
2. Choose appropriate state management approach
3. Design state shape and entity models
4. Implement actions, reducers, and selectors
5. Configure effects for side effects
6. Add DevTools integration for debugging

## Output Format

Return structured results:

- **State Architecture Design**
- **Store Implementation**
- **Effect Handlers**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **NgRx Best Practices** | Official NgRx patterns for scalable state management |
| **Signals API** | Angular signals for fine-grained reactivity |
| **Redux Pattern** | Unidirectional data flow principles |

## Anti-Hallucination Rules

- Do not assume NgRx version compatibility without checking
- Verify signal API availability in the target Angular version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- State shape is normalized and flat
- Selectors are properly memoized
- Effects handle error states gracefully
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Angular community best practices

## Integration Points

- **Companion Agent**: `@angular-state-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Angular coverage |