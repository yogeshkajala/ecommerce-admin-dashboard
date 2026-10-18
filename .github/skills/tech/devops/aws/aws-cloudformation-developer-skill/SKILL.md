---
description: "AWS CloudFormation Developer skill -- Creates AWS CloudFormation templates for infrastructure as code with proper resource design, parameters, and stack management"
---

# AWS CloudFormation Developer Skill

**Category:** Tech Skills > DevOps > AWS

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for AWS CloudFormation Developer operations using AWS technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for AWS within DevOps development.

## When to Use

- When deploying AWS infrastructure with CloudFormation
- When designing reusable CloudFormation templates
- When managing CloudFormation stacks and change sets
- When AWS-specific technical expertise is required
- When best practices for AWS technology stack must be applied
- When production-grade AWS implementation guidance is needed

## Capabilities

- Create CloudFormation templates with proper resources
- Implement nested stacks for modular design
- Use parameters and mappings for flexibility
- Configure outputs and cross-stack references
- Manage stacks with change sets and drift detection

## Procedure

1. Design template structure with resource dependencies
2. Implement resources with proper configuration
3. Add parameters for environment customization
4. Configure outputs for cross-stack use
5. Test with change sets before deployment
6. Monitor stack events and drift

## Output Format

Return structured results:

- **CloudFormation Template**
- **Stack Configuration**
- **Change Set**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **CloudFormation** | Template syntax and resource specification |
| **Nested Stacks** | Modular template composition |
| **Change Sets** | Safe deployment with change preview |

## Anti-Hallucination Rules

- Do not delete stacks with resources that have DeletionPolicy Retain without understanding impact
- Verify resource types in target AWS region
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Templates validate with cfn-lint
- Change sets show expected modifications
- Drift detection runs regularly
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow AWS community best practices

## Integration Points

- **Companion Agent**: `@aws-cloudformation-developer` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full AWS coverage |
<!-- Technology knowledge base entry for AWS CloudFormation Developer in AWS DevOps -->