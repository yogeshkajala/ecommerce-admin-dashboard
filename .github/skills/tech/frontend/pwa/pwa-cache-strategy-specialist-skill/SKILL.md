---
description: "PWA Cache Strategy Specialist skill -- Designs and implements advanced caching strategies for PWAs including runtime caching, cache partitioning, and storage quota management"
---

# PWA Cache Strategy Specialist Skill

**Category:** Tech Skills > Frontend > PWA

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PWA Cache Strategy Specialist operations using PWA technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PWA within Frontend development.

## When to Use

- When designing caching strategies for complex web applications
- When managing storage quotas and cache eviction policies
- When implementing runtime caching for API responses
- When PWA-specific technical expertise is required
- When best practices for PWA technology stack must be applied
- When production-grade PWA implementation guidance is needed

## Capabilities

- Design cache partitioning for different content types
- Implement runtime caching for API responses
- Manage storage quotas with eviction policies
- Configure cache versioning and invalidation
- Monitor cache performance and hit rates

## Procedure

1. Analyze content types and caching requirements
2. Design cache partitioning strategy
3. Implement runtime caching with proper TTLs
4. Configure storage quota management
5. Set up cache analytics and monitoring
6. Test cache behavior under various network conditions

## Output Format

Return structured results:

- **Caching Architecture**
- **Eviction Policies**
- **Performance Metrics**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Cache Storage API** | Browser cache storage quotas and management |
| **Workbox Strategies** | Caching strategy patterns and plugins |
| **Storage API** | StorageManager for quota estimation |

## Anti-Hallucination Rules

- Do not assume unlimited cache storage on any platform
- Verify cache API support in target browsers
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Cache partitions match content lifecycle
- Eviction policies prevent storage overflow
- Cache hit rates meet performance targets
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PWA community best practices

## Integration Points

- **Companion Agent**: `@pwa-cache-strategy-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PWA coverage |
<!-- Technology knowledge base entry for PWA Cache Strategy Specialist in PWA Frontend -->