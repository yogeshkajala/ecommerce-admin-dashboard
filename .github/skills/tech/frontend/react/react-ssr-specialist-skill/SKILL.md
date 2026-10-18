---
description: "React SSR Specialist skill -- Implements server-side rendering for React applications with hydration, streaming, and server component patterns"
---

# React SSR Specialist Skill

**Category:** Tech Skills > Frontend > React

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for React SSR Specialist operations using React technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for React within Frontend development.

## When to Use

- When implementing server-side rendering for SEO and performance
- When configuring streaming SSR with React 18 features
- When migrating from client-side to server-rendered React
- When React-specific technical expertise is required
- When best practices for React technology stack must be applied
- When production-grade React implementation guidance is needed

## Capabilities

- Implement SSR with renderToString and renderToPipeableStream
- Configure streaming SSR with Suspense boundaries
- Handle hydration mismatches and client-only rendering
- Implement server components with proper boundaries
- Set up SSR caching strategies for performance

## Procedure

1. Assess SSR requirements and SEO needs
2. Choose SSR approach: static, streaming, or hybrid
3. Implement server rendering with proper data fetching
4. Configure hydration with Suspense boundaries
5. Handle client-only components with lazy loading
6. Test SSR output and hydration correctness

## Output Format

Return structured results:

- **SSR Configuration**
- **Hydration Strategy**
- **Performance Metrics**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **React Server Components** | Server/client component boundary patterns |
| **Streaming SSR** | React 18 streaming with renderToPipeableStream |
| **SEO Requirements** | Meta tags and structured data for SSR pages |

## Anti-Hallucination Rules

- Do not assume React Server Component features without version check
- Verify streaming API availability in the target React version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Hydration mismatches are eliminated
- SEO requirements are met
- Time to first byte is optimized
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow React community best practices

## Integration Points

- **Companion Agent**: `@react-ssr-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full React coverage |