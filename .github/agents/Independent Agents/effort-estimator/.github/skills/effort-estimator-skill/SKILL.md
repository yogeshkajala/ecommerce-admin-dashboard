---
name: effort-estimator-skill
description: "Effort Estimator skill -- Use when producing effort estimates with confidence intervals based on scope, complexity, risk factors, and three-point PERT analysis."
---

# Effort Estimator Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for effort estimation operations. This skill encapsulates PERT estimation, work breakdown, and confidence interval calculation.

## When to Use

- When estimating development effort for new features or changes
- When breaking work into estimable tasks with time ranges
- When applying three-point PERT analysis (Optimistic/Most Likely/Pessimistic)
- When calculating confidence intervals for delivery forecasts
- When factoring risk, complexity, and testing effort into estimates

## Capabilities

- Break features into estimable work items (≤ 8 hours each)
- Apply three-point PERT estimation (O + 4M + P) / 6
- Calculate confidence intervals at 70% and 90% levels
- Factor in testing effort (typically 40-60% of development)
- Account for review cycles, rework, and integration time
- Apply contingency based on risk profile (20% known, 40% unknown)
- Produce effort breakdown by category (dev, test, integration, deploy)
- Compare estimates against historical velocity data

## Estimation Method (Three-Point PERT)

| Parameter | Description |
|-----------|-------------|
| Optimistic (O) | Best case, no complications |
| Most Likely (M) | Normal conditions, typical issues |
| Pessimistic (P) | Worst case, significant complications |
| Expected (E) | (O + 4M + P) / 6 |
| Std Deviation | (P - O) / 6 |

## Procedure

1. Receive feature scope from impact analysis and design phases
2. Break feature into work items (each ≤ 8 hours)
3. For each work item, estimate O/M/P considering complexity and risk
4. Include testing effort for each item (unit + integration + E2E)
5. Include integration and deployment effort
6. Calculate PERT expected duration and standard deviation
7. Sum all items and compute confidence intervals (70%, 90%)
8. Add contingency based on risk profile
9. Produce estimate report with breakdown and assumptions

## Output Format

Return structured results:

- **Estimate Summary**: total expected hours, confidence intervals
- **Work Breakdown**: item, category, O/M/P, expected, std dev
- **Category Totals**: development, testing, integration, deployment
- **Contingency**: risk-based buffer with justification
- **Assumptions**: key assumptions that could invalidate the estimate
- **Quality Gate**: PASS/FAIL (all items estimated with documented rationale)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **PERT** | Program Evaluation and Review Technique for three-point estimation |
| **COCOMO II** | Constructive Cost Model for software effort estimation |
| **Planning Poker** | Team-based relative estimation with Fibonacci sequence |
| **Story Points** | Relative complexity measurement for agile estimation |
