---
description: "PWA Push Notification Developer skill -- Implements push notification functionality for PWAs with subscription management, notification display, and user engagement strategies"
---

# PWA Push Notification Developer Skill

**Category:** Tech Skills > Frontend > PWA

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for PWA Push Notification Developer operations using PWA technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for PWA within Frontend development.

## When to Use

- When implementing web push notifications for PWAs
- When managing push subscription lifecycle and permissions
- When designing notification strategies for user engagement
- When PWA-specific technical expertise is required
- When best practices for PWA technology stack must be applied
- When production-grade PWA implementation guidance is needed

## Capabilities

- Implement Push API with VAPID key authentication
- Manage push subscription lifecycle and storage
- Display rich notifications with actions and images
- Handle notification clicks with proper navigation
- Design notification strategies for engagement and retention

## Procedure

1. Configure VAPID keys for push authentication
2. Implement push subscription management
3. Design notification payload schema
4. Handle push events in service worker
5. Implement notification click actions
6. Monitor notification delivery and engagement metrics

## Output Format

Return structured results:

- **Push Implementation**
- **Subscription Management**
- **Engagement Metrics**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Push API** | Web Push protocol and browser API |
| **Notification API** | Notification display and interaction patterns |
| **VAPID** | Voluntary Application Server Identification |

## Anti-Hallucination Rules

- Do not assume push notification support on all platforms
- Verify Push API availability in target browsers
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- VAPID keys are properly secured
- Notification permissions are requested appropriately
- Subscription state is properly managed
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow PWA community best practices

## Integration Points

- **Companion Agent**: `@pwa-push-notification-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full PWA coverage |
<!-- Technology knowledge base entry for PWA Push Notification Developer in PWA Frontend -->