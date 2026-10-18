---
description: "Node.js Package Manager skill -- Manages Node.js dependencies with npm, yarn, or pnpm including workspace configuration, lockfile management, and security auditing"
---

# Node.js Package Manager Skill

**Category:** Tech Skills > Backend > Node.js

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for Node.js Package Manager operations using Node.js technology. This skill encapsulates technology-specific best practices, design patterns, performance optimization techniques, and production-grade implementation guidance for Node.js within Backend development.

## When to Use

- When configuring monorepo workspaces with npm or pnpm
- When resolving dependency conflicts and version issues
- When auditing packages for security vulnerabilities
- When Node.js-specific technical expertise is required
- When best practices for Node.js technology stack must be applied
- When production-grade Node.js implementation guidance is needed

## Capabilities

- Configure npm/pnpm workspaces for monorepos
- Manage lockfile integrity and reproducible installs
- Resolve dependency version conflicts
- Run security audits with npm audit
- Publish packages with proper semver versioning

## Procedure

1. Assess dependency management requirements
2. Choose and configure package manager
3. Set up workspace configuration if monorepo
4. Resolve dependency conflicts
5. Run security audit and fix vulnerabilities
6. Configure CI/CD for reproducible installs

## Output Format

Return structured results:

- **Package Configuration**
- **Workspace Setup**
- **Audit Report**
- **Technical Assessment**: technology version compatibility, dependency analysis, risk factors
- **Implementation Plan**: step-by-step implementation with code examples and configuration
- **Performance Metrics**: baseline metrics, optimization targets, benchmark results
- **Action Items**: prioritized tasks with ownership, estimated effort, and acceptance criteria
- **Audit Trail**: timestamped log of all operations performed with input/output checksums

## Technology Standards

| Standard / Best Practice | Relevance |
|--------------------------|-----------|
| **npm Best Practices** | npm configuration and security guidelines |
| **pnpm Workspaces** | Efficient monorepo dependency management |
| **Semver** | Semantic versioning for package publishing |

## Anti-Hallucination Rules

- Do not modify lockfiles manually
- Verify package manager compatibility with CI/CD environment
- Do not fabricate version numbers, API endpoints, or library names
- Always cite the specific documentation, RFC, or standard being referenced
- If technology-specific data is unavailable, explicitly state the gap and request clarification
- Never assume features exist in a specific version without verification

## Quality Checks

- Lockfile is committed and reproducible
- No known vulnerabilities in dependencies
- Workspace hoisting is properly configured
- All code examples must be syntactically valid and tested
- Cross-reference findings against official documentation
- Flag any assumptions made during analysis with explicit markers
- Validate all performance claims with reproducible benchmarks
- Ensure all recommendations follow Node.js community best practices

## Integration Points

- **Companion Agent**: `@node-package-manager` from the Independent Agents catalogue
- **Input Sources**: Source code repositories, package registries, CI/CD pipelines, documentation
- **Output Consumers**: Development teams, code review systems, deployment pipelines, monitoring
- **Upstream Skills**: Architecture skills, design pattern skills, requirements skills
- **Downstream Skills**: Testing skills, deployment skills, monitoring skills, documentation skills

## Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0.0 | 2026-04-28 | Initial release with full Node.js coverage |
<!-- Technology knowledge base entry for Node.js Package Manager in Node.js Backend -->
<!-- Technology knowledge base entry for Node.js Package Manager in Node.js Backend -->