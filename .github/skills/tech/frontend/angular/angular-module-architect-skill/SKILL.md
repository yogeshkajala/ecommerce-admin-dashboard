---
description: "Angular Module Architect skill -- Designs scalable Angular module architecture with proper encapsulation, shared modules, and standalone component migration strategies"
---

# Angular Module Architect Skill

**Category:** Tech Skills > Frontend > Angular

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Angular Module Architect operations using Angular technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Angular within Frontend development.

## When to Use

- When designing modular Angular application architecture
- When migrating from NgModule to standalone components
- When creating shared module strategies for large applications
- When Angular-specific technical expertise is required
- When best practices for Angular technology stack must be applied
- When production-grade Angular implementation guidance is needed

## Capabilities

- Design feature module boundaries with proper encapsulation
- Create shared modules with exported components and directives
- Plan standalone component migration from NgModule apps
- Implement barrel exports for clean public APIs
- Configure module federation for micro-frontend architecture

## Procedure

1. Analyze application domain boundaries
2. Design feature module hierarchy
3. Create shared and core module structure
4. Implement lazy-loaded feature modules
5. Plan standalone component migration path
6. Document module dependencies and public APIs

## Output Format

Return structured results:

- **Module Architecture Diagram**
- **Migration Plan**
- **Dependency Map**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Angular Module Guide** | Official module organization and lazy loading patterns |
| **Standalone Migration** | Official migration guide from NgModules to standalone |
| **Module Federation** | Webpack Module Federation for Angular micro-frontends |

## Anti-Hallucination Rules

- Do not assume standalone components are available in Angular < 14
- Verify module federation compatibility with Angular version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Module boundaries follow domain boundaries
- Circular dependencies are eliminated
- Public APIs are well-defined and minimal
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Angular community best practices

## Integration Points

- **Companion Agent**: `@angular-module-architect` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Angular coverage |