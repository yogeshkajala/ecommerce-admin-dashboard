---
description: "Use when validating that implemented features meet acceptance criteria, verifying Given/When/Then scenarios, or producing acceptance reports."
---

# Acceptance Validation Standards

## Validation Process
- Every acceptance criterion must be verified individually
- Each verification must produce evidence (test output, logs, or screenshots)
- Verdicts: PASS (fully met), FAIL (not met), PARTIAL (partially met)
- 100% acceptance rate required for quality gate to pass

## Verification Rules
- Read acceptance criteria from requirements phase documentation
- For each Given/When/Then criterion:
  1. Identify the implementation that addresses it
  2. Execute or review evidence that behavior matches expected outcome
  3. Document the evidence supporting the verdict
- Never mark PASS without concrete evidence
- Never mark PARTIAL without specifying what is missing

## Acceptance Rate
- Formula: `passed_criteria / total_criteria × 100%`
- Gate threshold: 100% (all criteria must PASS)
- PARTIAL counts as FAIL for gate purposes

## Evidence Requirements
| Criterion Type | Acceptable Evidence |
|---------------|-------------------|
| Functional | Test result output showing expected behavior |
| Performance | Benchmark results meeting stated thresholds |
| Security | Scan report showing no violations |
| UI/UX | Screenshot or recording matching specification |

## Gap Handling
- Criteria without implementation → FAIL with "not implemented" note
- Criteria with ambiguous implementation → PARTIAL with specific gap description
- All FAIL/PARTIAL items must have recommended action to resolve

## Report Format
- Per-criterion table: ID, criterion text, verdict, evidence reference
- Summary: total, passed, failed, partial, acceptance rate
- Recommendation: proceed / fix and re-validate / redesign
