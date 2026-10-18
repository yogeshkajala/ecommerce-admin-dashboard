---
description: "Go Microservices Developer skill -- Builds microservices in Go with gRPC, protocol buffers, service discovery, and distributed tracing for production-grade systems"
---

# Go Microservices Developer Skill

**Category:** Tech Skills > Backend > Go

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Go Microservices Developer operations using Go technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Go within Backend development.

## When to Use

- When building gRPC services with protocol buffers
- When implementing service-to-service communication in Go
- When adding distributed tracing and observability
- When Go-specific technical expertise is required
- When best practices for Go technology stack must be applied
- When production-grade Go implementation guidance is needed

## Capabilities

- Build gRPC services with protobuf definitions
- Implement service discovery with Consul or etcd
- Add distributed tracing with OpenTelemetry
- Configure health checks and readiness probes
- Design circuit breaker patterns for resilience

## Procedure

1. Define service contracts with protobuf
2. Implement gRPC server and client
3. Configure service discovery and load balancing
4. Add OpenTelemetry instrumentation
5. Implement health checks and graceful shutdown
6. Test with integration and contract tests

## Output Format

Return structured results:

- **Service Implementation**
- **Proto Definitions**
- **Tracing Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **gRPC Go** | Go gRPC implementation patterns |
| **OpenTelemetry Go** | Distributed tracing and metrics |
| **Protobuf** | Protocol buffer design guidelines |

## Anti-Hallucination Rules

- Do not assume gRPC features are version-independent
- Verify protobuf compatibility with target gRPC version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Proto definitions follow style guide
- Services handle graceful shutdown
- Tracing covers all service boundaries
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Go community best practices

## Integration Points

- **Companion Agent**: `@go-microservices-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Go coverage |
<!-- Technology knowledge base entry for Go Microservices Developer in Go Backend -->
<!-- Technology knowledge base entry for Go Microservices Developer in Go Backend -->