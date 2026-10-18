---
description: "Next.js Static Generator skill -- Generates static pages with Next.js using generateStaticParams, static exports, and build-time data fetching for optimal delivery"
---

# Next.js Static Generator Skill

**Category:** Tech Skills > Frontend > Next.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Next.js Static Generator operations using Next.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Next.js within Frontend development.

## When to Use

- When generating static pages at build time with dynamic routes
- When configuring static exports for CDN deployment
- When optimizing build-time data fetching for large page sets
- When Next.js-specific technical expertise is required
- When best practices for Next.js technology stack must be applied
- When production-grade Next.js implementation guidance is needed

## Capabilities

- Implement generateStaticParams for dynamic routes
- Configure static export for full static site generation
- Optimize build-time data fetching with parallel requests
- Handle incremental static regeneration for hybrid sites
- Generate sitemaps and robots.txt at build time

## Procedure

1. Identify pages suitable for static generation
2. Implement generateStaticParams with data sources
3. Configure build-time data fetching optimization
4. Set up fallback behavior for new pages
5. Generate sitemap and metadata files
6. Validate build output and page count

## Output Format

Return structured results:

- **Static Generation Config**
- **Build Optimization**
- **Sitemap Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Static Generation** | Build-time rendering with generateStaticParams |
| **Static Export** | Full static site export configuration |
| **Sitemap** | Automatic sitemap generation patterns |

## Anti-Hallucination Rules

- Do not assume all pages can be statically generated
- Verify static export limitations in the target Next.js version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All dynamic routes have proper static params
- Build times are optimized for large page sets
- Fallback behavior handles missing pages
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Next.js community best practices

## Integration Points

- **Companion Agent**: `@nextjs-static-generator` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Next.js coverage |