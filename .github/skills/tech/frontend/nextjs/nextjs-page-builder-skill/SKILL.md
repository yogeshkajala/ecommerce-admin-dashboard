---
description: "Next.js Page Builder skill -- Creates Next.js pages and layouts using App Router with server components, client components, and proper data fetching patterns"
---

# Next.js Page Builder Skill

**Category:** Tech Skills > Frontend > Next.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Next.js Page Builder operations using Next.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Next.js within Frontend development.

## When to Use

- When building pages with Next.js App Router and server components
- When implementing layouts with nested route groups
- When choosing between server and client component boundaries
- When Next.js-specific technical expertise is required
- When best practices for Next.js technology stack must be applied
- When production-grade Next.js implementation guidance is needed

## Capabilities

- Build pages with App Router file-based routing
- Implement shared layouts with proper nesting
- Design server/client component boundaries
- Create loading and error boundary components
- Implement parallel routes and intercepting routes

## Procedure

1. Analyze page requirements and data needs
2. Design route structure with groups and layouts
3. Implement pages with proper component boundaries
4. Add loading.tsx and error.tsx boundaries
5. Configure metadata with generateMetadata
6. Test pages with Next.js testing patterns

## Output Format

Return structured results:

- **Page Structure**
- **Layout Configuration**
- **Metadata Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **App Router** | File-based routing with server components |
| **Server Components** | React Server Component patterns in Next.js |
| **Metadata API** | SEO and social metadata generation |

## Anti-Hallucination Rules

- Do not mix Pages Router and App Router patterns
- Verify App Router features in the target Next.js version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Server/client boundaries are intentional
- Loading states cover all async pages
- Metadata is complete for SEO
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Next.js community best practices

## Integration Points

- **Companion Agent**: `@nextjs-page-builder` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Next.js coverage |
<!-- Technology knowledge base entry for Next.js Page Builder in Next.js Frontend -->