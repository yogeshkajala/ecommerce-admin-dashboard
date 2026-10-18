---
description: "AWS ECS Specialist skill -- Deploys containerized applications with Amazon ECS including Fargate, task definitions, and service auto-scaling"
---

# AWS ECS Specialist Skill

**Category:** Tech Skills > DevOps > AWS

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for AWS ECS Specialist operations using AWS technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for AWS within DevOps development.

## When to Use

- When deploying containers on ECS with Fargate
- When configuring ECS task definitions and services
- When implementing auto-scaling for ECS services
- When AWS-specific technical expertise is required
- When best practices for AWS technology stack must be applied
- When production-grade AWS implementation guidance is needed

## Capabilities

- Create ECS clusters with Fargate or EC2 launch types
- Design task definitions with proper resource allocation
- Configure services with load balancer integration
- Implement auto-scaling based on CPU or custom metrics
- Set up service discovery with Cloud Map

## Procedure

1. Design ECS cluster architecture
2. Create task definitions with container specs
3. Deploy services with proper networking
4. Configure load balancer and health checks
5. Set up auto-scaling policies
6. Monitor with CloudWatch Container Insights

## Output Format

Return structured results:

- **ECS Configuration**
- **Task Definitions**
- **Scaling Policies**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **ECS Best Practices** | Task and service configuration guidelines |
| **Fargate** | Serverless container deployment |
| **Service Discovery** | Cloud Map integration for ECS |

## Anti-Hallucination Rules

- Do not over-provision Fargate tasks without profiling
- Verify ECS features in target AWS region
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Tasks have proper health checks
- Auto-scaling responds to demand
- Service discovery works for inter-service calls
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow AWS community best practices

## Integration Points

- **Companion Agent**: `@aws-ecs-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full AWS coverage |
<!-- Technology knowledge base entry for AWS ECS Specialist in AWS DevOps -->
<!-- Technology knowledge base entry for AWS ECS Specialist in AWS DevOps -->
<!-- Technology knowledge base entry for AWS ECS Specialist in AWS DevOps -->