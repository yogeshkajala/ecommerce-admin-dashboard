# Observability

## Technical Definition
Metrics, Logs, Traces.

## Real-World Analogy
A car's dashboard (Metrics), a mechanic's notebook (Logs), GPS tracking a delivery (Traces).

## System Design Interview Tips
> 💡 **Tip:** Distributed tracing (like OpenTelemetry) is crucial in microservices to debug latency.

## Diagram
```mermaid
graph TD; A[Service] --> B[Prometheus (Metrics)]; A --> C[Elasticsearch (Logs)]; A --> D[Jaeger (Traces)];
```
