# Additional Concepts

## Technical Definition
CDN, Geohashing, S2 Geometry.

## Real-World Analogy
Stocking popular snacks at a local convenience store instead of ordering from the factory (CDN).

## System Design Interview Tips
> 💡 **Tip:** For location-based services (Uber, Yelp), mention Geohashing or Quadtrees.

## Diagram
```mermaid
graph LR; A[User] --> B[Edge Server (CDN)]; B -- Cache Miss --> C[Origin Server];
```
