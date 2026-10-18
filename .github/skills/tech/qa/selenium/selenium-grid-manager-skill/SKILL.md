---
description: "Selenium Grid Manager skill -- Deploys and manages Selenium Grid for distributed test execution with proper node configuration and Docker integration"
---

# Selenium Grid Manager Skill

**Category:** Tech Skills > QA > Selenium

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Selenium Grid Manager operations using Selenium technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Selenium within QA development.

## When to Use

- When setting up Selenium Grid for parallel test execution
- When deploying Grid with Docker Compose or Kubernetes
- When managing grid nodes and session distribution
- When Selenium-specific technical expertise is required
- When best practices for Selenium technology stack must be applied
- When production-grade Selenium implementation guidance is needed

## Capabilities

- Deploy Selenium Grid 4 with hub and nodes
- Configure Docker-based grid with Compose
- Implement dynamic grid scaling on Kubernetes
- Monitor grid sessions and node health
- Configure video recording for test sessions

## Procedure

1. Design grid topology for parallel execution
2. Deploy grid with Docker or Kubernetes
3. Configure node capabilities and capacity
4. Set up session distribution policies
5. Monitor grid health and utilization
6. Scale nodes based on demand

## Output Format

Return structured results:

- **Grid Configuration**
- **Docker Setup**
- **Monitoring Dashboard**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **Selenium Grid 4** | Grid architecture and configuration |
| **Docker Grid** | Container-based grid deployment |
| **Grid Scaling** | Dynamic node scaling patterns |

## Anti-Hallucination Rules

- Do not assume unlimited grid capacity
- Verify grid version compatibility with WebDriver
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Grid scales to meet parallel test demand
- Sessions are distributed evenly
- Failed nodes are detected and replaced
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Selenium community best practices

## Integration Points

- **Companion Agent**: `@selenium-grid-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Selenium coverage |
<!-- Technology knowledge base entry for Selenium Grid Manager in Selenium QA -->
<!-- Technology knowledge base entry for Selenium Grid Manager in Selenium QA -->
<!-- Technology knowledge base entry for Selenium Grid Manager in Selenium QA -->