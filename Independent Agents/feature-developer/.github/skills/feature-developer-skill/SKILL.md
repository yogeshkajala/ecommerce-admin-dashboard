---
description: "Feature Developer skill -- Use when implementing features with code generation, code review, integration testing, and documentation."
---
# Feature Developer Skill

## Purpose
Provides domain-specific knowledge and step-by-step procedures for Feature Developer operations.

## When to Use
- When performing development tasks that require specialized knowledge
- When structured output and validated results are needed
- When domain best practices and industry standards must be applied

## Capabilities
- Analyze codebases for quality, maintainability, and adherence to coding standards
- Implement features following SOLID principles and clean code practices
- Refactor code to reduce complexity, eliminate duplication, and improve testability
- Debug issues using systematic diagnosis with logging, breakpoints, and trace analysis
- Generate code following established patterns, conventions, and style guides
- Review pull requests for correctness, security, performance, and maintainability
- Integrate with development tools (linters, formatters, type checkers) for quality automation
- Produce technical documentation for APIs, modules, and architectural decisions

## Procedure
1. Receive development request -- identify requirements, constraints, and target codebase
2. Analyze existing code -- review structure, patterns, dependencies, and coding standards
3. Design solution -- select approach aligned with architecture patterns and quality requirements
4. Implement changes -- write code following SOLID principles, DRY, and project conventions
5. Add tests -- unit tests for logic, integration tests for boundaries, e2e for workflows
6. Validate quality -- run linters, type checkers, and static analysis tools
7. Review changes -- self-review for correctness, security, performance, and maintainability
8. Generate summary with changes made, test coverage, and any remaining technical debt

## Output Format
Return structured results:
- **Summary**: brief overview of analysis performed and key findings
- **Findings**: categorized list with severity, description, and evidence
- **Recommendations**: prioritized actions with effort, impact, and owner assignments
- **Metrics**: relevant quantitative measurements and trend indicators
- **Next Steps**: immediate actions, follow-up items, and escalation needs

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **ISO 25010** | Software quality model -- functional and non-functional quality characteristics |
| **SWEBOK** | Software engineering body of knowledge -- foundational practices and processes |
| **IEEE 730** | Software quality assurance planning and execution standards |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER make recommendations without supporting evidence or analysis
- ALWAYS verify assumptions against actual system or codebase state
