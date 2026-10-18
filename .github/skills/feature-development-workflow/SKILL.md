---
name: feature-development-workflow
description: "Execute a complete feature development workflow within an existing codebase with impact analysis and backward compatibility guarantees."
argument-hint: "Describe the feature or enhancement to develop within an existing system"
---
# Feature Development Workflow Skill

## When to Use
- Adding a feature to an existing codebase
- Extending functionality with backward compatibility requirements
- Need full impact analysis before making changes

## Procedure
1. Scan codebase to identify files and modules affected by the change
2. Map dependencies to understand cascading impact (2+ levels deep)
3. Assess risks with severity classification and mitigation strategies
4. Estimate effort using three-point PERT estimation
5. **Gate**: Present impact report for approval
6. Design feature architecture following existing patterns
7. Design API changes with backward compatibility assessment
8. Design data model changes with migration scripts
9. **Gate**: Design review approved
10. Generate code following existing conventions and feature flag integration
11. Review code for correctness, security, and pattern consistency
12. Run integration tests at all component touchpoints
13. Update documentation for all changes
14. **Gate**: Code review passed
15. Run regression tests on all affected modules
16. Benchmark performance against baseline (< 5% degradation allowed)
17. Scan for security vulnerabilities (OWASP Top 10)
18. Verify all acceptance criteria met
19. **Gate**: All validation suites pass

## Quality Checks Before Returning
- [ ] Impact analysis completed with risk mitigations
- [ ] Backward compatibility verified for API and data changes
- [ ] Code follows existing patterns and conventions
- [ ] Feature flag integration for progressive rollout
- [ ] Regression tests pass, no performance degradation
- [ ] Security scan clean, acceptance criteria met

## Rules
- NEVER skip impact analysis
- ALWAYS verify backward compatibility
- After 3 iteration cycles, escalate to user
