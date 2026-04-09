# Deployment Strategies

## Technical Definition
Blue/Green, Canary, Rolling updates.

## Real-World Analogy
Testing a new recipe on a few customers (Canary) vs opening a whole new duplicate restaurant (Blue/Green).

## System Design Interview Tips
> 💡 **Tip:** Blue/Green requires 2x capacity. Canary reduces blast radius of bad deployments.

## Diagram
```mermaid
graph TD; A[Load Balancer] -->|90%| B[V1 (Stable)]; A -->|10%| C[V2 (Canary)];
```
