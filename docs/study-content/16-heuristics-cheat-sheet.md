# System Design Heuristics (Cheat Sheet)

*Source: Neo Kim (15 System Design Interview Heuristics)*

These heuristics provide a quick mental map for selecting architectural components based on system constraints.

1. **Latency + Global → CDN**
   ↳ Deliver data from edge servers to reduce latency.

2. **Read + Bottleneck → Cache**
   ↳ Store frequent reads in cache to reduce database load.

3. **Write + Spike → Queue**
   ↳ Buffer writes for asynchronous processing during traffic spikes.

4. **Distributed + Transaction → Saga**
   ↳ Handle multi-service transactions with compensating steps.

5. **ACID + Relational → SQL**
   ↳ Use a SQL database for strong consistency and transactional integrity.

6. **Flexible + Scale → NoSQL**
   ↳ Use NoSQL for schema flexibility and horizontal scalability.

7. **SQL + Scale → Shard DB**
   ↳ Federate and partition data across shards to scale effectively.

8. **Load + Growth → Scale Out**
   ↳ Add servers to handle extra traffic.

9. **Traffic + Reliability → Load Balance**
   ↳ Distribute requests evenly for performance.

10. **Core + Failure → Redundancy**
    ↳ Replicate core services to avoid single points of failure.

11. **Durability + Faults → Replication**
    ↳ Replicate data for availability and recovery.

12. **Requests + Spike → Throttle**
    ↳ Limit excessive requests to prevent server overload.

13. **Load + Spike → Autoscale**
    ↳ Add or remove server capacity automatically to handle changing load.

14. **Realtime + Updates → WebSockets**
    ↳ Use WebSockets for live, bidirectional communication.

15. **Retry + Safety → Idempotent**
    ↳ Make operations safe to retry without side effects using idempotency.

*Note: These are heuristics. The correct solution always depends on the specific system requirements.*