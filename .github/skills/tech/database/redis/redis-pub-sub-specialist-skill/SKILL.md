---
description: "Redis Pub/Sub Specialist skill -- Implements real-time messaging with Redis Pub/Sub and Streams including pattern subscriptions, consumer groups, and message persistence"
---

# Redis Pub/Sub Specialist Skill

**Category:** Tech Skills > Database > Redis

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Redis Pub/Sub Specialist operations using Redis technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Redis within Database development.

## When to Use

- When implementing real-time messaging with Redis Pub/Sub
- When building event-driven architectures with Redis Streams
- When configuring consumer groups for reliable message processing
- When Redis-specific technical expertise is required
- When best practices for Redis technology stack must be applied
- When production-grade Redis implementation guidance is needed

## Capabilities

- Implement Pub/Sub for real-time broadcasting
- Build Redis Streams for persistent messaging
- Configure consumer groups for reliable processing
- Handle message acknowledgment and pending entries
- Design pattern subscriptions for topic routing

## Procedure

1. Analyze messaging requirements
2. Choose between Pub/Sub and Streams
3. Implement publishers and subscribers
4. Configure consumer groups if persistent delivery needed
5. Handle message failures and retries
6. Monitor message throughput and lag

## Output Format

Return structured results:

- **Messaging Architecture**
- **Consumer Configuration**
- **Monitoring Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Redis Pub/Sub** | Publish/subscribe messaging patterns |
| **Redis Streams** | Persistent log-based messaging |
| **Consumer Groups** | Reliable message processing with acknowledgment |

## Anti-Hallucination Rules

- Do not assume Pub/Sub messages are persistent - they are fire-and-forget
- Verify Streams features in target Redis version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Messages are delivered to all subscribers
- Consumer groups process without message loss
- Pending entries are handled within timeout
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Redis community best practices

## Integration Points

- **Companion Agent**: `@redis-pub-sub-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Redis coverage |
<!-- Technology knowledge base entry for Redis Pub/Sub Specialist in Redis Database -->