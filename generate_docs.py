import os

docs_dir = "/data/.openclaw/workspace/ecommerce-admin-dashboard/docs/study-content"
os.makedirs(docs_dir, exist_ok=True)

files = [
    ("03-system-architecture.md", "System Architecture", "Monolithic vs Microservices architecture.", "A single massive building vs a city of specialized buildings.", "Choose microservices when scaling teams, not just traffic.", "graph TD; A[Client] --> B[API Gateway]; B --> C[Service 1]; B --> D[Service 2];"),
    ("04-apis-communication.md", "APIs & Communication", "REST, GraphQL, gRPC.", "A restaurant menu (REST), a custom order (GraphQL), a fast-food drive-thru (gRPC).", "Discuss latency vs payload size. gRPC is great for internal microservices.", "sequenceDiagram; Client->>Server: HTTP GET /users; Server-->>Client: JSON Response;"),
    ("05-distributed-systems.md", "Distributed Systems", "CAP Theorem, Consistency Models.", "Choosing between a fast but potentially outdated rumor vs waiting for official news.", "Always state which part of CAP you are giving up. Hint: Networks fail, so P is required. Choose C or A.", "graph LR; A[Node 1] -- Network Partition -x B[Node 2];"),
    ("06-performance-scaling.md", "Performance & Scaling", "Vertical vs Horizontal Scaling.", "Upgrading to a bigger truck (Vertical) vs buying a fleet of small vans (Horizontal).", "Horizontal scaling is generally preferred for stateless services.", "graph TD; A[Load Balancer] --> B[Server 1]; A --> C[Server 2]; A --> D[Server 3];"),
    ("07-reliability-patterns.md", "Reliability Patterns", "Circuit Breakers, Retries, Rate Limiting.", "A circuit breaker in a house preventing an electrical fire.", "Use exponential backoff with jitter to prevent thundering herd problems.", "graph TD; A[Service A] -- Fails --> B{Circuit Breaker}; B -- Open --> C[Fallback]; B -- Closed --> D[Service B];"),
    ("08-security.md", "Security", "Authentication, Authorization, TLS.", "Checking ID at the door (AuthN) vs checking VIP pass for the back room (AuthZ).", "Never trust the client. Mention mTLS for internal service communication.", "graph LR; A[Client] -- HTTPS/TLS --> B[Server];"),
    ("09-messaging-async-systems.md", "Messaging & Async Systems", "Message Queues, Pub/Sub.", "Leaving a voicemail (Queue) vs a radio broadcast (Pub/Sub).", "Queues decouple producers from consumers and handle traffic spikes.", "graph LR; A[Producer] -->|Message| B[(Queue/Topic)]; B -->|Consume| C[Consumer];"),
    ("10-observability.md", "Observability", "Metrics, Logs, Traces.", "A car's dashboard (Metrics), a mechanic's notebook (Logs), GPS tracking a delivery (Traces).", "Distributed tracing (like OpenTelemetry) is crucial in microservices to debug latency.", "graph TD; A[Service] --> B[Prometheus (Metrics)]; A --> C[Elasticsearch (Logs)]; A --> D[Jaeger (Traces)];"),
    ("11-data-processing-search.md", "Data Processing & Search", "Batch vs Stream Processing, ElasticSearch.", "Doing laundry once a week (Batch) vs washing clothes as they get dirty (Stream).", "Use Elasticsearch/Solr for full-text search, not standard relational DBs.", "graph LR; A[Data Source] --> B[Kafka]; B --> C[Stream Processor]; C --> D[(Database)];"),
    ("12-advanced-data-structures.md", "Advanced Data Structures", "Bloom Filters, HyperLogLog, Consistent Hashing.", "A club bouncer who knows exactly who is NOT on the list (Bloom Filter).", "Bloom filters give false positives but never false negatives. Great for cache lookups.", "graph TD; A[Key] --> B[Hash Function 1]; A --> C[Hash Function 2]; B --> D[Bit Array]; C --> D;"),
    ("13-modern-data-platforms.md", "Modern Data Platforms", "Data Warehouse vs Data Lake vs Data Lakehouse.", "A neatly organized library (Warehouse) vs a massive warehouse of raw unorganized boxes (Lake).", "Discuss separation of compute and storage (e.g., Snowflake).", "graph TD; A[Raw Data] --> B[(Data Lake)]; B --> C[ETL/ELT]; C --> D[(Data Warehouse)];"),
    ("14-deployment-strategies.md", "Deployment Strategies", "Blue/Green, Canary, Rolling updates.", "Testing a new recipe on a few customers (Canary) vs opening a whole new duplicate restaurant (Blue/Green).", "Blue/Green requires 2x capacity. Canary reduces blast radius of bad deployments.", "graph TD; A[Load Balancer] -->|90%| B[V1 (Stable)]; A -->|10%| C[V2 (Canary)];"),
    ("15-additional-concepts.md", "Additional Concepts", "CDN, Geohashing, S2 Geometry.", "Stocking popular snacks at a local convenience store instead of ordering from the factory (CDN).", "For location-based services (Uber, Yelp), mention Geohashing or Quadtrees.", "graph LR; A[User] --> B[Edge Server (CDN)]; B -- Cache Miss --> C[Origin Server];")
]

template = """# {title}

## Technical Definition
{definition}

## Real-World Analogy
{analogy}

## System Design Interview Tips
> 💡 **Tip:** {tips}

## Diagram
```mermaid
{diagram}
```
"""

for filename, title, definition, analogy, tips, diagram in files:
    filepath = os.path.join(docs_dir, filename)
    with open(filepath, "w") as f:
        f.write(template.format(title=title, definition=definition, analogy=analogy, tips=tips, diagram=diagram))

print(f"Generated {len(files)} files in {docs_dir}")
