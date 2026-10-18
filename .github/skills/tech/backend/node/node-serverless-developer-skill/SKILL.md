---
description: "Node.js Serverless Developer skill -- Builds serverless applications with Node.js on AWS Lambda, Azure Functions, or Vercel including cold start optimization and event processing"
---

# Node.js Serverless Developer Skill

**Category:** Tech Skills > Backend > Node.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Node.js Serverless Developer operations using Node.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Node.js within Backend development.

## When to Use

- When building serverless functions with Node.js runtimes
- When optimizing cold start times for Lambda or Azure Functions
- When implementing event-driven serverless architectures
- When Node.js-specific technical expertise is required
- When best practices for Node.js technology stack must be applied
- When production-grade Node.js implementation guidance is needed

## Capabilities

- Build AWS Lambda handlers with proper event typing
- Create Azure Functions with bindings and triggers
- Optimize cold start with provisioned concurrency
- Implement event-driven architectures with SQS/EventBridge
- Design serverless API layers with API Gateway

## Procedure

1. Analyze function requirements and triggers
2. Implement handler with proper event processing
3. Optimize bundle size for cold start
4. Configure IAM permissions and environment
5. Set up local development and testing
6. Deploy with infrastructure as code

## Output Format

Return structured results:

- **Lambda Handler**
- **Configuration**
- **Performance Metrics**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **AWS Lambda** | Lambda best practices for Node.js |
| **Serverless Framework** | Multi-cloud serverless deployment patterns |
| **Cold Start** | Cold start optimization techniques |

## Anti-Hallucination Rules

- Do not assume unlimited execution time in serverless functions
- Verify Node.js runtime version availability on target platform
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Functions handle timeouts gracefully
- Cold start times meet latency requirements
- Event processing is idempotent
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Node.js community best practices

## Integration Points

- **Companion Agent**: `@node-serverless-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Node.js coverage |