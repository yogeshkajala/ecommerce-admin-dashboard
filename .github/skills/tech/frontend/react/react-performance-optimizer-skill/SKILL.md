---
description: "React Performance Optimizer skill -- Profiles and optimizes React application performance through rendering analysis, memoization, and bundle size optimization"
---

# React Performance Optimizer Skill

**Category:** Tech Skills > Frontend > React

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for React Performance Optimizer operations using React technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for React within Frontend development.

## When to Use

- When diagnosing React rendering performance issues
- When implementing memoization strategies for expensive computations
- When optimizing React bundle size and initial load time
- When React-specific technical expertise is required
- When best practices for React technology stack must be applied
- When production-grade React implementation guidance is needed

## Capabilities

- Profile rendering with React DevTools Profiler
- Implement React.memo with custom comparison functions
- Optimize with useMemo, useCallback, and useTransition
- Analyze and reduce bundle size with source map explorer
- Implement virtualization for long lists with react-window

## Procedure

1. Baseline performance with Lighthouse and React Profiler
2. Identify unnecessary re-renders in component tree
3. Apply memoization where performance impact is measurable
4. Implement virtualization for large data sets
5. Optimize bundle with code splitting and tree shaking
6. Validate improvements against baseline metrics

## Output Format

Return structured results:

- **Performance Audit**
- **Optimization Plan**
- **Benchmark Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **React Profiler** | Official profiling tool for rendering analysis |
| **Core Web Vitals** | LCP, INP, CLS targets for React applications |
| **Bundle Analysis** | Source map explorer for bundle optimization |

## Anti-Hallucination Rules

- Do not fabricate performance numbers without measurement
- Verify optimization techniques apply to the target React version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Optimizations are backed by profiling data
- Memoization does not add unnecessary complexity
- Bundle size improvements are measurable
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow React community best practices

## Integration Points

- **Companion Agent**: `@react-performance-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full React coverage |