---
description: "Use when producing effort estimates, breaking work into tasks, applying PERT analysis, or calculating confidence intervals for delivery."
---

# Effort Estimation Standards

## Estimation Method (Three-Point PERT)
- Optimistic (O): Best case, no complications
- Most Likely (M): Normal conditions, typical issues
- Pessimistic (P): Worst case, significant complications
- Expected: (O + 4M + P) / 6
- Standard Deviation: (P - O) / 6

## Work Breakdown Rules
- Every task must be ≤ 8 hours (break larger items down)
- Include testing effort explicitly (40-60% of development time)
- Include code review and rework cycles (10-20% of development)
- Include integration and deployment effort separately

## Contingency Guidelines
| Risk Level | Contingency Buffer |
|------------|-------------------|
| Low (known tech, experienced team) | 20% |
| Medium (some unknowns) | 30% |
| High (new tech, unclear requirements) | 40-50% |

## Confidence Intervals
- Always provide at least two intervals: 70% and 90%
- 70% confidence: Expected ± 1 std dev
- 90% confidence: Expected ± 1.65 std dev

## Anti-Patterns (NEVER do)
- Single-point estimates without ranges
- Estimates without documented assumptions
- Ignoring testing/integration/deployment effort
- Padding individual tasks instead of applying contingency at total level
- Estimating without understanding scope (always read impact analysis first)

## Output Requirements
- Breakdown by category: development, testing, integration, deployment
- Total with confidence intervals (70%, 90%)
- Key assumptions that could invalidate the estimate
- Comparison to historical data if available
