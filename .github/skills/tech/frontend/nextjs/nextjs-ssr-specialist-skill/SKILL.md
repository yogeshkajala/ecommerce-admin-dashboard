---
description: "Next.js SSR Specialist skill -- Implements server-side rendering strategies in Next.js with streaming, caching, and revalidation for optimal performance"
---

# Next.js SSR Specialist Skill

**Category:** Tech Skills > Frontend > Next.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Next.js SSR Specialist operations using Next.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Next.js within Frontend development.

## When to Use

- When configuring SSR with streaming and Suspense boundaries
- When implementing ISR with on-demand revalidation
- When optimizing server rendering performance with caching
- When Next.js-specific technical expertise is required
- When best practices for Next.js technology stack must be applied
- When production-grade Next.js implementation guidance is needed

## Capabilities

- Configure streaming SSR with Suspense boundaries
- Implement ISR with time-based and on-demand revalidation
- Set up fetch caching with proper revalidation strategies
- Handle dynamic rendering with cookies and headers
- Implement partial prerendering for hybrid pages

## Procedure

1. Assess rendering requirements per page
2. Configure data fetching with proper cache settings
3. Implement Suspense boundaries for streaming
4. Set up revalidation strategies
5. Configure CDN caching headers
6. Benchmark rendering performance

## Output Format

Return structured results:

- **Rendering Strategy**
- **Cache Configuration**
- **Performance Metrics**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Data Fetching** | fetch API with cache and revalidation options |
| **ISR** | Incremental Static Regeneration patterns |
| **Streaming** | React Suspense-based streaming SSR |

## Anti-Hallucination Rules

- Do not assume cache behavior without checking Next.js version defaults
- Verify PPR availability in the target Next.js version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Cache strategies match content freshness requirements
- Streaming boundaries optimize time to first byte
- Revalidation is configured for dynamic content
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Next.js community best practices

## Integration Points

- **Companion Agent**: `@nextjs-ssr-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Next.js coverage |
<!-- Technology knowledge base entry for Next.js SSR Specialist in Next.js Frontend -->