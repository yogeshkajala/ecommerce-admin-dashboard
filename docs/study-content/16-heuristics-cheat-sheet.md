# System Design Heuristics (Cheat Sheet)

*Source: Neo Kim (15 System Design Interview Heuristics)*

These heuristics provide a quick mental map for selecting architectural components based on system constraints.

1. **Latency + Global → CDN**
   ↳ Deliver data from edge servers to reduce latency.
   * **How it works:** Content Delivery Networks cache static content (images, JS, CSS, videos) on distributed edge servers close to the user's geographical location.
   * **Real-World Example:** **Netflix** uses Open Connect, its custom CDN, to cache video files at ISPs worldwide, drastically reducing buffering and backbone bandwidth usage.
   * **Trade-offs:** Cache invalidation is notoriously difficult; CDNs can serve stale data if not properly purged. Added cost and configuration complexity.

2. **Read + Bottleneck → Cache**
   ↳ Store frequent reads in cache to reduce database load.
   * **How it works:** An in-memory data store (like Redis or Memcached) is placed in front of a primary database. When a read request comes in, the system checks the cache first (cache hit), falling back to the database only if missing (cache miss).
   * **Real-World Example:** **Twitter** relies heavily on Redis caches to serve user timelines, caching pre-computed timeline feeds for active users to enable instant load times.
   * **Trade-offs:** Memory is expensive; cache coherence/invalidation adds complexity. If the cache dies and there's a "thundering herd", the database can be overwhelmed.

3. **Write + Spike → Queue**
   ↳ Buffer writes for asynchronous processing during traffic spikes.
   * **How it works:** A message broker (like Kafka, RabbitMQ, or SQS) acts as a buffer. During traffic spikes, requests are enqueued rapidly and background workers process them asynchronously at a manageable rate.
   * **Real-World Example:** **Ticketmaster** uses queues during high-demand concert sales. Users are placed in a virtual waiting room, and their purchase requests are queued to avoid crashing the transaction database.
   * **Trade-offs:** Introduces eventual consistency (users don't get immediate confirmation). Requires complex error handling, dead-letter queues, and monitoring for stalled workers.

4. **Distributed + Transaction → Saga**
   ↳ Handle multi-service transactions with compensating steps.
   * **How it works:** A sequence of local transactions spanning multiple microservices. If one step fails, compensating transactions are triggered to undo the previous successful steps, maintaining eventual consistency without distributed locks.
   * **Real-World Example:** **Uber** uses the Saga pattern for ride bookings: it must atomically charge the user, assign a driver, and update trip status across different independent services.
   * **Trade-offs:** Very complex to design, debug, and test. Requires writing "rollback" logic for every step. Can lead to weird intermediate states visible to the user.

5. **ACID + Relational → SQL**
   ↳ Use a SQL database for strong consistency and transactional integrity.
   * **How it works:** Relational databases (like PostgreSQL or MySQL) use strict schemas and enforce ACID (Atomicity, Consistency, Isolation, Durability) properties, ensuring data is never left in an invalid state even during crashes.
   * **Real-World Example:** **Stripe** uses relational databases (PostgreSQL) as the source of truth for financial ledgers because dropping a transaction or having inconsistent balance data is unacceptable.
   * **Trade-offs:** Hard to scale horizontally. Rigid schemas require formal migrations which can slow down rapid development.

6. **Flexible + Scale → NoSQL**
   ↳ Use NoSQL for schema flexibility and horizontal scalability.
   * **How it works:** Non-relational databases (like MongoDB, Cassandra, or DynamoDB) store data in documents, wide-columns, or key-value pairs without rigid schema constraints, designed natively for horizontal scaling across commodity hardware.
   * **Real-World Example:** **Amazon** uses DynamoDB to handle the massive scale and flexibility required for user shopping carts, which have varied attributes and require extreme high-availability.
   * **Trade-offs:** Often sacrifices strong consistency for availability (Eventual Consistency). Difficult to do complex multi-table joins; relationships must usually be handled in application logic.

7. **SQL + Scale → Shard DB**
   ↳ Federate and partition data across shards to scale effectively.
   * **How it works:** Data is partitioned horizontally across multiple database instances based on a shard key (e.g., user ID). Each database acts as a standalone unit holding a fraction of the total dataset.
   * **Real-World Example:** **Discord** successfully sharded trillions of messages across Cassandra clusters (and later ScyllaDB) by organizing them via Channel ID and Server ID.
   * **Trade-offs:** Re-sharding (moving data when a shard gets full) is incredibly dangerous and complex. Cross-shard joins or transactions are extremely slow or completely impossible.

8. **Load + Growth → Scale Out**
   ↳ Add servers to handle extra traffic.
   * **How it works:** Horizontal scaling involves adding more servers to a resource pool rather than upgrading a single server's hardware (scaling up). Traffic is then distributed among these servers.
   * **Real-World Example:** **Facebook** scales out its web tier by deploying tens of thousands of stateless PHP/Hack web servers that can be added or removed dynamically.
   * **Trade-offs:** Requires applications to be completely stateless. Increases networking complexity, server management overhead, and requires load balancing.

9. **Traffic + Reliability → Load Balance**
   ↳ Distribute requests evenly for performance.
   * **How it works:** A reverse proxy or hardware load balancer (like HAProxy, NGINX, or AWS ALB) sits in front of backend servers and routes incoming client requests across them using algorithms like Round Robin or Least Connections.
   * **Real-World Example:** **Cloudflare** heavily utilizes load balancing to distribute incoming DDoS attacks and normal web traffic across its vast global network of servers to prevent any single machine from going down.
   * **Trade-offs:** The load balancer itself can become a single point of failure if not deployed redundantly. Can complicate session state (often requiring sticky sessions or external state stores).

10. **Core + Failure → Redundancy**
    ↳ Replicate core services to avoid single points of failure.
    * **How it works:** Critical system components are duplicated (servers, databases, network links) so that if the primary component fails, a standby can immediately take over (Active-Passive or Active-Active setups).
    * **Real-World Example:** **Google** deploys redundant power supplies, network switches, and data centers. If an entire data center loses power, traffic is automatically routed to another redundant facility.
    * **Trade-offs:** Doubles (or triples) infrastructure costs. Requires complex failover mechanisms and health checks to detect failures accurately without triggering "split-brain" scenarios.

11. **Durability + Faults → Replication**
    ↳ Replicate data for availability and recovery.
    * **How it works:** Data is continuously copied from a primary node to one or more replica nodes. If the primary node crashes or corrupts data, replicas contain a safe backup that can be promoted to primary.
    * **Real-World Example:** **WhatsApp** replicates its user metadata and routing tables across global server nodes to ensure that even if a region goes offline, message delivery can continue seamlessly.
    * **Trade-offs:** Replication lag means read-replicas might serve slightly outdated data. Synchronous replication ensures no data loss but adds significant write latency.

12. **Requests + Spike → Throttle**
    ↳ Limit excessive requests to prevent server overload.
    * **How it works:** Rate limiting controls the rate of traffic sent or received by a network interface. Algorithms like Token Bucket or Leaky Bucket reject or delay requests that exceed a set threshold.
    * **Real-World Example:** **GitHub API** implements strict rate limiting (e.g., 5000 requests per hour for authenticated users) to prevent automated scripts from degrading service for everyone else.
    * **Trade-offs:** Legitimate users might be blocked during organic traffic spikes. Requires an efficient distributed counter (like Redis) to track request rates globally.

13. **Load + Spike → Autoscale**
    ↳ Add or remove server capacity automatically to handle changing load.
    * **How it works:** Cloud orchestration systems (like Kubernetes HPA or AWS Auto Scaling Groups) monitor metrics like CPU or memory usage. When thresholds are crossed, the system automatically spins up new instances or tears them down.
    * **Real-World Example:** **Zoom** leveraged massive autoscaling on AWS to handle the unprecedented surge in video conferencing traffic during the early 2020 pandemic lockdowns, spinning up thousands of servers dynamically.
    * **Trade-offs:** Autoscaling takes time (minutes to boot a server), so it might not respond fast enough to instant spikes. Can lead to massive cloud bills if not capped or monitored properly.

14. **Realtime + Updates → WebSockets**
    ↳ Use WebSockets for live, bidirectional communication.
    * **How it works:** Unlike HTTP, which is stateless and request-response driven, WebSockets establish a persistent, bidirectional TCP connection between the client and server, allowing the server to push updates instantly.
    * **Real-World Example:** **Robinhood** uses WebSockets to stream live stock price tickers and portfolio updates to millions of mobile clients with sub-second latency.
    * **Trade-offs:** Maintaining millions of persistent connections consumes significant memory and file descriptors on the server. Load balancing WebSockets is harder than HTTP.

15. **Retry + Safety → Idempotent**
    ↳ Make operations safe to retry without side effects using idempotency.
    * **How it works:** An API endpoint or operation is designed so that making multiple identical requests has the same effect as making a single request, safely accommodating network timeouts and retries.
    * **Real-World Example:** **PayPal** payment APIs use idempotency keys (usually a UUID generated by the client). If a network timeout occurs and the client retries the payment, PayPal recognizes the key and prevents double-charging.
    * **Trade-offs:** Requires the server to store a history of recently processed request IDs (state). Adds complexity to the application layer to distinguish between a new request and a retry.

*Note: These are heuristics. The correct solution always depends on the specific system requirements.*