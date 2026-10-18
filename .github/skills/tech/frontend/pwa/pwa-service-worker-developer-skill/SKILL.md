---
description: "PWA Service Worker Developer skill -- Develops service workers for Progressive Web Apps with caching strategies, background sync, and lifecycle management"
---

# PWA Service Worker Developer Skill

**Category:** Tech Skills > Frontend > PWA

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PWA Service Worker Developer operations using PWA technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PWA within Frontend development.

## When to Use

- When implementing offline-first strategies with service workers
- When configuring caching strategies for different resource types
- When handling service worker updates and activation
- When PWA-specific technical expertise is required
- When best practices for PWA technology stack must be applied
- When production-grade PWA implementation guidance is needed

## Capabilities

- Implement cache-first, network-first, and stale-while-revalidate strategies
- Configure precaching for critical application assets
- Handle service worker lifecycle with install, activate, and fetch events
- Implement background sync for offline form submissions
- Manage service worker updates with skip waiting patterns

## Procedure

1. Identify caching requirements for each resource type
2. Design caching strategy matrix
3. Implement service worker with Workbox or vanilla SW
4. Configure precaching manifest for critical assets
5. Add background sync for offline operations
6. Test offline behavior and cache invalidation

## Output Format

Return structured results:

- **Service Worker Implementation**
- **Caching Strategy**
- **Offline Behavior Tests**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Service Worker API** | Web API specification for service workers |
| **Workbox** | Google's service worker library for caching strategies |
| **Cache API** | Cache storage patterns and size management |

## Anti-Hallucination Rules

- Do not assume service worker support in all target browsers
- Verify Workbox version compatibility with build tools
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Caching strategies match resource update frequency
- Service worker updates do not break existing sessions
- Cache sizes are managed with expiration policies
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PWA community best practices

## Integration Points

- **Companion Agent**: `@pwa-service-worker-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PWA coverage |