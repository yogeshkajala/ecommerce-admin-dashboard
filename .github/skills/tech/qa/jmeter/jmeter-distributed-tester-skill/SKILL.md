---
description: "JMeter Distributed Tester skill -- Configures JMeter distributed testing across multiple machines for high-volume load generation and result aggregation"
---

# JMeter Distributed Tester Skill

**Category:** Tech Skills > QA > JMeter

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for JMeter Distributed Tester operations using JMeter technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for JMeter within QA development.

## When to Use

- When running distributed load tests across multiple machines
- When configuring JMeter server mode for remote execution
- When aggregating results from distributed test runs
- When JMeter-specific technical expertise is required
- When best practices for JMeter technology stack must be applied
- When production-grade JMeter implementation guidance is needed

## Capabilities

- Configure JMeter in distributed mode
- Set up remote test engines
- Aggregate results from multiple nodes
- Configure network for distributed execution
- Monitor resource usage across test nodes

## Procedure

1. Design distributed test architecture
2. Configure JMeter server on remote nodes
3. Set up controller with remote configuration
4. Run distributed test
5. Aggregate and analyze results
6. Monitor node resource utilization

## Output Format

Return structured results:

- **Distributed Configuration**
- **Node Setup**
- **Aggregated Results**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Distributed Testing** | JMeter remote testing configuration |
| **Result Aggregation** | Combining results from multiple nodes |
| **Network Config** | RMI and network settings for distribution |

## Anti-Hallucination Rules

- Do not run distributed tests without coordinating with infrastructure team
- Verify network connectivity between nodes
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- All nodes participate in test execution
- Results are properly aggregated
- Network latency between nodes is minimal
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow JMeter community best practices

## Integration Points

- **Companion Agent**: `@jmeter-distributed-tester` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full JMeter coverage |
<!-- Technology knowledge base entry for JMeter Distributed Tester in JMeter QA -->
<!-- Technology knowledge base entry for JMeter Distributed Tester in JMeter QA -->