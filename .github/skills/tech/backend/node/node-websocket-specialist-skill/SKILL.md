---
description: "Node.js WebSocket Specialist skill -- Implements WebSocket communication in Node.js with Socket.io or ws library including room management, scaling, and reconnection handling"
---

# Node.js WebSocket Specialist Skill

**Category:** Tech Skills > Backend > Node.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Node.js WebSocket Specialist operations using Node.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Node.js within Backend development.

## When to Use

- When building real-time features with WebSocket connections
- When implementing room-based messaging with Socket.io
- When scaling WebSocket connections across multiple servers
- When Node.js-specific technical expertise is required
- When best practices for Node.js technology stack must be applied
- When production-grade Node.js implementation guidance is needed

## Capabilities

- Implement WebSocket servers with ws or Socket.io
- Design room and namespace management
- Configure Redis adapter for horizontal scaling
- Handle reconnection and connection state
- Implement binary message protocols

## Procedure

1. Analyze real-time communication requirements
2. Choose WebSocket library and protocol
3. Implement server with connection management
4. Design message protocol and room structure
5. Configure scaling with Redis adapter
6. Load test WebSocket connections

## Output Format

Return structured results:

- **WebSocket Server**
- **Message Protocol**
- **Scaling Configuration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **WebSocket Protocol** | RFC 6455 WebSocket protocol specification |
| **Socket.io** | Socket.io rooms, namespaces, and scaling |
| **ws Library** | Lightweight WebSocket library for Node.js |

## Anti-Hallucination Rules

- Do not assume WebSocket connections survive network changes
- Verify WebSocket library version features
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Connections handle disconnection and reconnection gracefully
- Scaling supports the required concurrent connections
- Message delivery is reliable with proper ordering
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Node.js community best practices

## Integration Points

- **Companion Agent**: `@node-websocket-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Node.js coverage |
<!-- Technology knowledge base entry for Node.js WebSocket Specialist in Node.js Backend -->