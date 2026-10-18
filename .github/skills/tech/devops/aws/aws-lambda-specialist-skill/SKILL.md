---
description: "AWS Lambda Specialist skill -- Builds serverless applications with AWS Lambda including function design, event sources, and performance optimization"
---

# AWS Lambda Specialist Skill

**Category:** Tech Skills > DevOps > AWS

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for AWS Lambda Specialist operations using AWS technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for AWS within DevOps development.

## When to Use

- When building serverless functions with AWS Lambda
- When optimizing Lambda cold start and execution performance
- When implementing event-driven architectures with Lambda triggers
- When AWS-specific technical expertise is required
- When best practices for AWS technology stack must be applied
- When production-grade AWS implementation guidance is needed

## Capabilities

- Design Lambda functions with proper memory and timeout
- Configure event source mappings for SQS, S3, DynamoDB
- Optimize cold start with provisioned concurrency
- Implement Lambda Layers for shared dependencies
- Configure VPC access and security groups

## Procedure

1. Design function with proper handler structure
2. Configure event sources and triggers
3. Set memory and timeout based on profiling
4. Implement layers for shared code
5. Configure IAM roles with least privilege
6. Test with SAM local and integration tests

## Output Format

Return structured results:

- **Lambda Function**
- **Event Configuration**
- **Performance Metrics**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Lambda Best Practices** | Function design and performance guidelines |
| **SAM** | Serverless Application Model for deployment |
| **Lambda Powertools** | Operational tooling for Lambda |

## Anti-Hallucination Rules

- Do not assume Lambda execution environment persists between invocations
- Verify Lambda runtime support for target language version
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Cold start times meet latency requirements
- IAM roles follow least privilege
- Function handles errors and retries properly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow AWS community best practices

## Integration Points

- **Companion Agent**: `@aws-lambda-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full AWS coverage |
<!-- Technology knowledge base entry for AWS Lambda Specialist in AWS DevOps -->