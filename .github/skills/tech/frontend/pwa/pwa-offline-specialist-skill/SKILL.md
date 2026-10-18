---
description: "PWA Offline Specialist skill -- Implements offline-first functionality for PWAs including offline data storage, conflict resolution, and progressive enhancement"
---

# PWA Offline Specialist Skill

**Category:** Tech Skills > Frontend > PWA

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PWA Offline Specialist operations using PWA technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PWA within Frontend development.

## When to Use

- When implementing offline-first application architecture
- When handling data synchronization and conflict resolution
- When designing graceful degradation for network failures
- When PWA-specific technical expertise is required
- When best practices for PWA technology stack must be applied
- When production-grade PWA implementation guidance is needed

## Capabilities

- Implement IndexedDB storage for offline data
- Design conflict resolution for offline edits
- Build offline queue with retry and reconciliation
- Create offline UI indicators and fallback pages
- Handle progressive enhancement for offline features

## Procedure

1. Identify critical offline user journeys
2. Design offline data storage schema
3. Implement IndexedDB with proper versioning
4. Build sync queue for offline operations
5. Create conflict resolution strategy
6. Test offline scenarios with network simulation

## Output Format

Return structured results:

- **Offline Architecture**
- **Sync Strategy**
- **Conflict Resolution**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **IndexedDB** | Structured storage for offline web applications |
| **Background Sync** | Deferred sync for offline operations |
| **Progressive Enhancement** | Graceful feature degradation patterns |

## Anti-Hallucination Rules

- Do not assume IndexedDB storage limits are consistent across browsers
- Verify background sync support in target browsers
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Critical user journeys work fully offline
- Data synchronization handles conflicts correctly
- Offline indicators inform users of connectivity state
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PWA community best practices

## Integration Points

- **Companion Agent**: `@pwa-offline-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PWA coverage |
<!-- Technology knowledge base entry for PWA Offline Specialist in PWA Frontend -->