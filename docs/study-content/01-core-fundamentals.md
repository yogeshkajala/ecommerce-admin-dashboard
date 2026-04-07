# Core Fundamentals

Welcome to the Core Fundamentals module! This document covers the essential building blocks of System Design. Understanding these concepts is critical before diving into complex architectures.

## 1. Scalability
**Definition:** Scalability is the measure of a system's ability to handle a growing amount of work by adding resources to the system. It can be achieved by scaling up (vertical scaling - adding more CPU/RAM to a single machine) or scaling out (horizontal scaling - adding more machines to a cluster).
**Analogy:** Imagine a busy restaurant. Vertical scaling is like hiring a faster chef or buying a bigger stove. Horizontal scaling is like building a larger restaurant or opening a second location to serve more customers simultaneously.
**Interview Tips:** 
- Almost always favor horizontal scaling in system design interviews because it avoids the hardware limits (ceiling) of a single machine and provides redundancy.
- Be prepared to discuss the trade-offs: horizontal scaling introduces complexity (load balancing, state management, distributed data) that vertical scaling avoids.

## 2. Availability
**Definition:** Availability is the percentage of time a system remains operational and accessible to users over a specific period. It is typically measured in "nines" (e.g., 99.9% or "three nines" means about 8.77 hours of downtime per year).
**Analogy:** A 24/7 convenience store that is occasionally forced to close for 10 minutes a month for cleaning has very high availability. A bank that closes every weekend and every night has low availability.
**Interview Tips:**
- Use the formula `Availability = Uptime / (Uptime + Downtime)`.
- Discuss Single Points of Failure (SPOF) and how eliminating them (via replication and failover mechanisms) improves availability.
- Acknowledge that 100% availability is practically impossible; target what the business requirements dictate.

## 3. Reliability
**Definition:** Reliability is the probability that a system will perform its intended function without failure under specified conditions for a specified period of time.
**Analogy:** A car that starts every single morning without breaking down is highly reliable. If it starts 99 days out of 100, but on the 100th day the engine explodes, it's highly available (mostly online) but fundamentally unreliable because it fails catastrophically at doing its job.
**Interview Tips:**
- Clarify the difference between Availability and Reliability: A system can be available (up and accepting requests) but unreliable (returning errors or incorrect data).
- Mention monitoring, logging, and chaos engineering as ways to measure and ensure reliability.

## 4. Latency
**Definition:** Latency is the time it takes for a single request to travel from the client, be processed by the server, and have the response return to the client. It is usually measured in milliseconds (ms).
**Analogy:** Latency is the time it takes from the moment you hand your order to the waiter until the moment they place the food on your table.
**Interview Tips:**
- Differentiate between network latency (time over the wire) and processing latency (time spent computing the response or querying the DB).
- Propose caching (CDN, Redis/Memcached) or moving servers closer to the user (edge computing) to reduce latency.

## 5. Throughput
**Definition:** Throughput is the amount of work or number of requests a system can process within a specific window of time (e.g., Requests Per Second or RPS, Transactions Per Second or TPS).
**Analogy:** Throughput is the total number of customers the restaurant can successfully serve and bill over a one-hour lunch rush.
**Interview Tips:**
- Understand the relationship between latency and throughput: improving throughput doesn't always improve latency. You can process many requests concurrently (high throughput) but each might still take a long time (high latency).
- Identify bottlenecks: the component with the lowest throughput dictates the maximum throughput of the entire system.

## 6. Bandwidth
**Definition:** Bandwidth is the maximum theoretical capacity or rate of data transfer across a network path, typically measured in bits per second (bps, Mbps, Gbps).
**Analogy:** Bandwidth is the width of a highway. A wider highway (higher bandwidth) allows more cars (data) to pass at the same time, but it doesn't make the cars drive any faster (latency).
**Interview Tips:**
- Use bandwidth to estimate data transfer costs and network saturation. 
- Mention data compression techniques and minimizing payload sizes to efficiently utilize available bandwidth.

## 7. Client-Server Model
**Definition:** A distributed application structure that partitions tasks or workloads between the providers of a resource or service (servers) and service requesters (clients).
**Analogy:** The customer (client) sits at the table and makes a request. The kitchen (server) receives the request, prepares the meal, and sends it back. The customer doesn't need to know how to cook, and the kitchen doesn't need to know how to eat.
**Interview Tips:**
- Discuss statelessness: ideally, the server should not store client state between requests (stateless architecture) so that any server instance can handle any request, making horizontal scaling much easier.
- Introduce middle layers like Load Balancers and API Gateways to manage how clients talk to the backend servers.