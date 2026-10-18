---
description: "Angular Performance Optimizer skill -- Analyzes and optimizes Angular application performance through change detection tuning, bundle optimization, and runtime profiling"
---

# Angular Performance Optimizer Skill

**Category:** Tech Skills > Frontend > Angular

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Angular Performance Optimizer operations using Angular technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Angular within Frontend development.

## When to Use

- When optimizing Angular application load time and runtime performance
- When reducing bundle size with tree shaking and code splitting
- When profiling change detection and rendering performance
- When Angular-specific technical expertise is required
- When best practices for Angular technology stack must be applied
- When production-grade Angular implementation guidance is needed

## Capabilities

- Profile and optimize change detection cycles
- Implement OnPush strategy and pure pipes for rendering
- Configure tree shaking and dead code elimination
- Optimize bundle size with lazy loading and preloading
- Use Angular DevTools for performance profiling

## Procedure

1. Baseline performance metrics with Lighthouse and DevTools
2. Profile change detection with Angular DevTools
3. Identify performance bottlenecks in rendering
4. Implement OnPush and pure pipes where applicable
5. Optimize bundle size with lazy loading
6. Validate performance improvements against baselines

## Output Format

Return structured results:

- **Performance Audit**
- **Optimization Plan**
- **Bundle Analysis**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Core Web Vitals** | LCP, FID, CLS targets for Angular applications |
| **Bundle Analysis** | Webpack bundle analyzer for size optimization |
| **Angular Performance** | Official performance checklist and optimization guide |

## Anti-Hallucination Rules

- Do not fabricate performance numbers without actual measurement
- Verify optimization techniques apply to the target Angular version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Performance improvements are measurable
- Bundle size reduction is verified
- Change detection optimizations do not break functionality
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Angular community best practices

## Integration Points

- **Companion Agent**: `@angular-performance-optimizer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Angular coverage |