---
description: "Node.js Stream Processor skill -- Builds efficient data processing pipelines using Node.js streams with Transform streams, pipeline composition, and backpressure management"
---

# Node.js Stream Processor Skill

**Category:** Tech Skills > Backend > Node.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Node.js Stream Processor operations using Node.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Node.js within Backend development.

## When to Use

- When processing large files or data sets with Node.js streams
- When building ETL pipelines with stream composition
- When handling backpressure in high-throughput stream processing
- When Node.js-specific technical expertise is required
- When best practices for Node.js technology stack must be applied
- When production-grade Node.js implementation guidance is needed

## Capabilities

- Build Transform streams for data processing
- Compose streams with pipeline() function
- Handle backpressure with proper highWaterMark configuration
- Implement duplex streams for bidirectional communication
- Process large files without loading into memory

## Procedure

1. Analyze data processing requirements
2. Design stream pipeline architecture
3. Implement Transform streams for processing stages
4. Configure backpressure and buffer sizes
5. Test with various data volumes
6. Monitor memory usage during processing

## Output Format

Return structured results:

- **Stream Pipeline Design**
- **Backpressure Config**
- **Memory Profile**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Node Streams** | Stream API v3 patterns and best practices |
| **Pipeline API** | Composing streams with pipeline() |
| **Backpressure** | Handling flow control in stream processing |

## Anti-Hallucination Rules

- Do not assume stream.pipe() handles errors correctly
- Verify stream API version features in target Node version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Memory usage stays constant regardless of data size
- Backpressure is properly handled throughout pipeline
- Error handling covers all stream stages
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Node.js community best practices

## Integration Points

- **Companion Agent**: `@node-stream-processor` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Node.js coverage |