---
description: "AWS Networking Specialist skill -- Designs AWS networking with VPCs, subnets, transit gateways, and security groups for secure and scalable cloud infrastructure"
---

# AWS Networking Specialist Skill

**Category:** Tech Skills > DevOps > AWS

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for AWS Networking Specialist operations using AWS technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for AWS within DevOps development.

## When to Use

- When designing VPC architecture for production workloads
- When implementing transit gateway for multi-VPC connectivity
- When configuring security groups and NACLs for network security
- When AWS-specific technical expertise is required
- When best practices for AWS technology stack must be applied
- When production-grade AWS implementation guidance is needed

## Capabilities

- Design VPC with proper CIDR and subnet planning
- Configure transit gateway for multi-VPC routing
- Implement security groups with least privilege
- Set up VPC endpoints for private service access
- Configure Route 53 for DNS management

## Procedure

1. Design VPC CIDR and subnet layout
2. Configure routing with internet and NAT gateways
3. Implement transit gateway for VPC connectivity
4. Set up security groups and NACLs
5. Configure VPC endpoints for AWS services
6. Test connectivity and isolation

## Output Format

Return structured results:

- **VPC Architecture**
- **Security Configuration**
- **Routing Design**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **VPC Design** | VPC architecture and subnet planning |
| **Transit Gateway** | Multi-VPC connectivity patterns |
| **Security Groups** | Stateful firewall rule design |

## Anti-Hallucination Rules

- Do not use 0.0.0.0/0 in security group ingress without justification
- Verify networking features in target AWS region
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- VPC design supports growth
- Security groups follow least privilege
- VPC endpoints reduce internet traffic
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow AWS community best practices

## Integration Points

- **Companion Agent**: `@aws-networking-specialist` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full AWS coverage |
<!-- Technology knowledge base entry for AWS Networking Specialist in AWS DevOps -->
<!-- Technology knowledge base entry for AWS Networking Specialist in AWS DevOps -->