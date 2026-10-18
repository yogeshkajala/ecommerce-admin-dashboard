---
description: "Jenkins Agent Manager skill -- Configures Jenkins build agents including Docker-based agents, Kubernetes pod agents, and cloud-provisioned agents for scalable builds"
---

# Jenkins Agent Manager Skill

**Category:** Tech Skills > DevOps > Jenkins

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Jenkins Agent Manager operations using Jenkins technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Jenkins within DevOps development.

## When to Use

- When configuring Docker or Kubernetes agents for Jenkins
- When implementing ephemeral agents for clean builds
- When scaling Jenkins build capacity with cloud agents
- When Jenkins-specific technical expertise is required
- When best practices for Jenkins technology stack must be applied
- When production-grade Jenkins implementation guidance is needed

## Capabilities

- Configure Docker-based build agents
- Set up Kubernetes pod templates for agents
- Implement cloud agents with EC2 or Azure VM
- Design agent labels and node affinity
- Monitor agent utilization and capacity

## Procedure

1. Analyze build agent requirements
2. Choose agent provisioning strategy
3. Configure agent templates with proper tools
4. Implement labeling for workload routing
5. Set up auto-scaling for demand
6. Monitor agent health and utilization

## Output Format

Return structured results:

- **Agent Configuration**
- **Scaling Strategy**
- **Monitoring Setup**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Jenkins Agents** | Agent configuration and management |
| **K8s Plugin** | Kubernetes pod template patterns |
| **Docker Agent** | Docker-based agent configuration |

## Anti-Hallucination Rules

- Do not run builds on the Jenkins controller node
- Verify agent plugin compatibility
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Agents are ephemeral and clean
- Scaling meets build demand
- Agent tools match pipeline requirements
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Jenkins community best practices

## Integration Points

- **Companion Agent**: `@jenkins-agent-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Jenkins coverage |
<!-- Technology knowledge base entry for Jenkins Agent Manager in Jenkins DevOps -->
<!-- Technology knowledge base entry for Jenkins Agent Manager in Jenkins DevOps -->
<!-- Technology knowledge base entry for Jenkins Agent Manager in Jenkins DevOps -->