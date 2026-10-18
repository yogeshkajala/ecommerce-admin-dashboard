---
description: ".NET Blazor Developer skill -- Builds interactive web applications with Blazor Server and Blazor WebAssembly including component design, state management, and JS interop"
---

# .NET Blazor Developer Skill

**Category:** Tech Skills > Backend > .NET

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for .NET Blazor Developer operations using .NET technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for .NET within Backend development.

## When to Use

- When building interactive web UIs with Blazor components
- When choosing between Blazor Server and WebAssembly hosting
- When implementing JavaScript interop for browser APIs
- When .NET-specific technical expertise is required
- When best practices for .NET technology stack must be applied
- When production-grade .NET implementation guidance is needed

## Capabilities

- Build Blazor components with parameters and events
- Implement Blazor Server and WebAssembly hosting models
- Design state management with cascading values
- Create JS interop for browser API access
- Build render tree optimization with virtualization

## Procedure

1. Choose appropriate Blazor hosting model
2. Design component hierarchy and data flow
3. Implement components with proper lifecycle methods
4. Add state management strategy
5. Configure JS interop for needed browser features
6. Test with bUnit testing framework

## Output Format

Return structured results:

- **Component Architecture**
- **Hosting Configuration**
- **Interop Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Blazor Component Model** | Component lifecycle and rendering patterns |
| **Blazor Performance** | Virtualization and render optimization |
| **bUnit** | Blazor component testing framework |

## Anti-Hallucination Rules

- Do not mix Blazor Server and WASM patterns without noting trade-offs
- Verify Blazor features match the target .NET version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Components render efficiently without excess updates
- State management prevents memory leaks in Server mode
- JS interop handles disposal properly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow .NET community best practices

## Integration Points

- **Companion Agent**: `@dotnet-blazor-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full .NET coverage |
<!-- Technology knowledge base entry for .NET Blazor Developer in .NET Backend -->