---
name: defect-fixer-skill
description: "Defect Fixer skill -- Use when performing root cause analysis (5 Whys, fault tree), implementing minimal-impact fixes, assessing fix blast radius, or preparing hotfix patches for defects."
---
# Defect Fixer Skill

## Purpose
Provides domain knowledge for diagnosing defects, implementing minimal-impact fixes, and verifying corrections with regression tests.

## When to Use
- When a defect needs root cause analysis before fixing
- When assessing blast radius of a proposed fix
- When implementing a minimal-impact code change for a bug
- When writing regression tests to prevent recurrence

## Capabilities
- Apply 5 Whys technique to trace symptom to root cause
- Perform fault tree analysis for complex multi-factor defects
- Assess blast radius: identify callers, dependents, and side effects of changed code
- Implement minimal-impact fixes that don't introduce regression risk
- Write regression tests covering the exact failure scenario
- Classify severity: Critical (data loss/security), High (feature broken), Medium (degraded), Low (cosmetic)

## Procedure
1. Reproduce the defect -- confirm the failure with a failing test or manual steps
2. Gather evidence -- collect logs, stack traces, and failing assertions
3. Apply 5 Whys -- trace from symptom through layers to root cause
4. Assess blast radius -- identify all callers, consumers, and modules affected by the fix
5. Implement fix -- minimal change targeting the root cause, not symptoms
6. Write regression test -- cover the exact scenario that triggered the defect
7. Verify fix -- run test suite, confirm no regressions introduced
8. Document -- root cause statement, fix rationale, and blast radius assessment

## Output Format
Return structured results:
- **Root Cause**: statement with evidence (logs, traces, code references)
- **5 Whys Chain**: symptom → why₁ → why₂ → ... → root cause
- **Blast Radius**: affected modules, APIs, consumers, and test coverage
- **Fix Description**: minimal change with before/after code
- **Regression Test**: test scenario covering the failure mode
- **Severity**: classification with justification

## Industry Standards
| Standard | Relevance |
|----------|-----------|
| **IEEE 1044** | Software anomaly classification and resolution |
| **ITIL Incident Management** | Structured defect lifecycle from detection to resolution |
| **ISTQB Defect Management** | Defect severity, priority, and lifecycle states |

## Anti-Hallucination Rules
- NEVER fabricate data, metrics, or measurements -- use only verified sources
- ALWAYS cite the source file, document, or system for any referenced data
- NEVER assume system state without querying or verifying current conditions
- ALWAYS validate inputs against expected formats before processing
- NEVER skip required validation or verification steps in procedures
- NEVER make recommendations without supporting evidence or analysis
- ALWAYS verify assumptions against actual system or codebase state
