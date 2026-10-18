---
description: ".NET SignalR Specialist skill -- Implements real-time communication with SignalR for web applications including hub design, scaling, and client integration patterns"
---

# .NET SignalR Specialist Skill

**Category:** Tech Skills > Backend > .NET

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for .NET SignalR Specialist operations using .NET technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for .NET within Backend development.

## When to Use

- When building real-time features with SignalR hubs
- When scaling SignalR with Redis backplane or Azure SignalR
- When implementing strongly-typed hub clients
- When .NET-specific technical expertise is required
- When best practices for .NET technology stack must be applied
- When production-grade .NET implementation guidance is needed

## Capabilities

- Design SignalR hubs with proper method contracts
- Implement strongly-typed hub interfaces
- Configure Redis backplane for horizontal scaling
- Build reconnection and error handling on clients
- Set up Azure SignalR Service for managed hosting

## Procedure

1. Analyze real-time communication requirements
2. Design hub methods and group management
3. Implement hub with authentication and authorization
4. Configure scaling strategy
5. Build client integration with reconnection
6. Test with concurrent connection load

## Output Format

Return structured results:

- **Hub Design**
- **Scaling Configuration**
- **Client Integration**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **SignalR Documentation** | Official SignalR hub and client patterns |
| **Scaling SignalR** | Backplane and Azure SignalR Service patterns |
| **WebSocket Protocol** | Transport protocol and fallback strategies |

## Anti-Hallucination Rules

- Do not assume WebSocket support in all deployment environments
- Verify SignalR version compatibility with .NET version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Hubs handle disconnection gracefully
- Scaling configuration supports required concurrent connections
- Messages are delivered reliably with proper ordering
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow .NET community best practices

## Integration Points

- **Companion Agent**: `@dotnet-signalr-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full .NET coverage |
<!-- Technology knowledge base entry for .NET SignalR Specialist in .NET Backend -->