---
name: risk-assessor-skill
description: "Risk Assessor skill -- Use when assessing project risks for impact, likelihood, priority ranking, and mitigation planning."
---

# Risk Assessor Skill

**Category:** Domain Skills

## Purpose

Provides specialized knowledge, step-by-step procedures, and quality standards for risk assessment operations. This skill encapsulates risk scoring frameworks, impact-likelihood matrices, and mitigation strategy patterns.

## When to Use

- When assessing identified project risks for impact and likelihood
- When computing composite risk scores and priority rankings
- When categorizing risks into response tiers (critical, high, medium, low)
- When identifying correlated risks that may trigger cascading failures
- When planning risk mitigation strategies and contingencies

## Capabilities

- Score risk impact across multiple dimensions (cost, schedule, quality, scope)
- Estimate risk likelihood using quantitative and qualitative methods
- Compute composite risk scores using impact-likelihood matrices
- Rank risks by priority for mitigation resource allocation
- Categorize risks into response tiers (critical, high, medium, low)
- Identify risk clusters and correlated risk groups
- Apply Monte Carlo or sensitivity analysis for high-impact risks
- Produce risk heat maps and priority-ranked risk dashboards

## Risk Matrix

| Likelihood / Impact | Negligible | Minor | Moderate | Major | Severe |
|---------------------|-----------|-------|----------|-------|--------|
| Almost Certain | Medium | High | High | Critical | Critical |
| Likely | Medium | Medium | High | High | Critical |
| Possible | Low | Medium | Medium | High | High |
| Unlikely | Low | Low | Medium | Medium | High |
| Rare | Low | Low | Low | Medium | Medium |

## Procedure

1. Receive risk assessment request -- identify project scope and risk register
2. Define impact and likelihood scales for consistent scoring
3. Score each risk for impact across cost, schedule, quality, and scope
4. Estimate likelihood for each risk using available evidence
5. Compute composite risk scores and plot on the risk matrix
6. Identify correlated risks that may trigger cascading failures
7. Rank risks by composite score and assign response tiers
8. Define mitigation strategies: avoid, transfer, mitigate, accept
9. Produce the assessed risk register with scores, rankings, and heat map

## Output Format

Return structured results:

- **Risk Summary**: total risks assessed, distribution by tier
- **Risk Register**: risk ID, description, impact, likelihood, score, tier, owner
- **Heat Map**: visual risk matrix with risk placement
- **Correlations**: identified risk clusters and cascading failure paths
- **Mitigation Plan**: strategy, actions, owner, timeline per high/critical risk
- **Quality Gate**: PASS/FAIL (no unmitigated Critical risks to pass)

## Industry Standards

| Standard | Relevance |
|----------|-----------|
| **ISO 31000** | Risk management principles and guidelines |
| **PMI Risk Management** | Project risk identification, analysis, and response planning |
| **FAIR** | Factor Analysis of Information Risk -- quantitative risk model |
| **NIST RMF** | Risk Management Framework for information systems |
