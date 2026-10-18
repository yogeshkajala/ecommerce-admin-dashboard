---
name: acceptance-validator-skill
description: "Acceptance Validator skill -- Use when verifying that implemented features meet all defined acceptance criteria, mapping each criterion to evidence of PASS/FAIL."
---

# Acceptance Validator Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for acceptance validation operations. This skill encapsulates criteria verification, evidence collection, and acceptance rate calculation.

## When to Use

- When verifying implemented features against acceptance criteria
- When mapping Given/When/Then criteria to test evidence
- When calculating acceptance rates (passed / total criteria)
- When determining if a feature is ready for deployment
- When producing acceptance reports with per-criterion verdicts

## Capabilities

- Retrieve acceptance criteria from requirements phase documentation
- Verify each criterion individually against implementation
- Execute scenarios and compare actual vs expected behavior
- Collect evidence (test output, logs, screenshots) for each verdict
- Mark each criterion as PASS, FAIL, or PARTIAL with justification
- Calculate overall acceptance rate
- Identify gaps between requirements and implementation
- Produce acceptance report with actionable feedback

## Procedure

1. Retrieve acceptance criteria from requirements phase documentation
2. For each Given/When/Then criterion:
   a. Identify the implementation that addresses it
   b. Verify behavior matches expected outcome
   c. Execute scenario or review test results for evidence
   d. Mark as PASS (fully met), FAIL (not met), or PARTIAL (partially met)
   e. Document evidence supporting the verdict
3. Calculate acceptance rate: passed / total criteria
4. Identify any criteria without corresponding implementation
5. Produce acceptance report with per-criterion results and overall verdict

## Output Format

Return structured results:

- **Acceptance Summary**: total criteria, passed, failed, partial, acceptance rate
- **Per-Criterion Results**: criterion ID, Given/When/Then, verdict, evidence
- **Gaps**: criteria without implementation or insufficient coverage
- **Recommendations**: actions needed to achieve full acceptance
- **Quality Gate**: PASS/FAIL (100% acceptance rate required to pass)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **BDD/Gherkin** | Given/When/Then format for acceptance criteria specification |
| **IEEE 829** | Test documentation standard for results reporting |
| **Definition of Done** | Agile completion criteria including AC verification |
