---
name: acceptance-criteria-definer-skill
description: "Acceptance Criteria Definer skill -- Use when defining testable acceptance criteria for user stories using Given/When/Then or equivalent formats."
---

# Acceptance Criteria Definer Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge for defining testable acceptance criteria using Given/When/Then format, ensuring criteria are measurable, specific, and development-ready.

## When to Use

- When defining testable acceptance criteria for user stories
- When converting requirements into Given/When/Then scenarios
- When ensuring criteria are specific, measurable, and verifiable
- When validating completeness of acceptance criteria before development

## Capabilities

- Write acceptance criteria in Given/When/Then (Gherkin) format
- Define happy path, error path, and edge case scenarios
- Ensure criteria are testable with clear pass/fail conditions
- Validate criteria for completeness (all paths covered)
- Check criteria for ambiguity and unmeasurable language
- Map criteria to specific test scenarios for verification
- Ensure non-functional requirements have measurable thresholds
- Validate criteria readiness for development handoff

## Procedure

1. Receive user story or feature description -- identify actors, actions, and expected outcomes
2. Identify all scenarios: happy path, alternate flows, error conditions, edge cases
3. Write each scenario in Given/When/Then format with specific, measurable conditions
4. Validate criteria for testability -- each criterion must have a clear pass/fail condition
5. Check for completeness -- ensure all functional and non-functional requirements are covered
6. Remove ambiguous language (e.g., "fast", "easy", "user-friendly") and replace with measurable thresholds
7. Map criteria to test types (unit, integration, E2E) for traceability
8. Review criteria against INVEST principles (Independent, Negotiable, Valuable, Estimable, Small, Testable)

## Output Format

Return structured results:

- **Feature Summary**: brief description of the feature and its user value
- **Acceptance Criteria**: numbered list of Given/When/Then scenarios grouped by category
- **Happy Path**: primary success scenarios
- **Error Handling**: validation failures, system errors, boundary conditions
- **Edge Cases**: unusual inputs, concurrent access, empty states
- **Non-Functional**: performance thresholds, security requirements, accessibility
- **Coverage Matrix**: mapping of criteria to user story requirements

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **IEEE 730** | Software quality assurance processes and standards |
| **ISO 25010** | Software quality model: functional suitability, reliability, maintainability |

## Anti-Hallucination Rules

- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER claim compliance without evidence from actual control evaluation
- ALWAYS verify regulatory applicability for the specific jurisdiction and context

## Constraints

- NEVER execute destructive operations without explicit user confirmation
- NEVER store, log, or expose secrets, credentials, or PII in output
- ALWAYS provide evidence for assertions -- no claims without supporting data
- ALWAYS follow the principle of least privilege for tool and data access
- NEVER override compliance requirements without documented exception approval
- ALWAYS maintain audit trail for all assessments and decisions
