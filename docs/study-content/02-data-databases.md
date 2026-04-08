# 02 - Data & Databases

This document covers essential concepts related to data storage, retrieval, and database management systems, which form the foundation of any large-scale application.

---

## 1. Databases
**Technical Definition:** A database is an organized collection of structured or unstructured data, typically stored electronically in a computer system. A Database Management System (DBMS) interacts with end-users, applications, and the database itself to capture and analyze the data.
**Real-world Analogy:** Think of a database as a highly organized filing cabinet in a large office. Instead of papers thrown in a box, everything is sorted into folders (tables/collections) with tabs (indexes) so you can find exactly what you need quickly.
**System Design Interview Tips:** 
- Always clarify the read-to-write ratio when choosing a database.
- Be prepared to discuss how your database choice affects latency and consistency.

## 2. SQL vs NoSQL
**Technical Definition:** 
- **SQL (Relational Databases):** Use structured query language and have a pre-defined schema. Data is stored in tables with rows and columns (e.g., PostgreSQL, MySQL).
- **NoSQL (Non-Relational Databases):** Have dynamic schemas for unstructured data. Data is stored in many ways: document-oriented, column-oriented, graph-based, or key-value stores (e.g., MongoDB, Cassandra, Redis).
**Real-world Analogy:** 
- **SQL:** A strict Excel spreadsheet where every column has a specific data type and every row must adhere to the structure.
- **NoSQL:** A scrapbook where you can paste photos, write notes, or attach tickets on any page without a rigid format.
**System Design Interview Tips:** 
- Choose SQL for complex queries, strict ACID compliance, and structured data (e.g., financial systems).
- Choose NoSQL for rapid development, unstructured data, high write throughput, and horizontal scalability.

## 3. Indexing
**Technical Definition:** An index is a data structure (often a B-tree or Hash table) that improves the speed of data retrieval operations on a database table at the cost of additional writes and storage space to maintain the index data structure.
**Real-world Analogy:** The index at the back of a textbook. Instead of reading every page to find information on "sharding," you look it up in the index, which tells you exactly which pages to read.
**System Design Interview Tips:** 
- Mention that adding indexes slows down `INSERT`, `UPDATE`, and `DELETE` operations.
- Discuss composite indexes when querying multiple columns together frequently.

## 4. Sharding
**Technical Definition:** Sharding (or horizontal partitioning) is a database architecture pattern related to partitioning by separating one table's rows into multiple different tables, known as partitions or shards. Each shard has the same schema and columns, but different rows.
**Real-world Analogy:** Imagine a huge library. Instead of putting all books in one massive room (which makes finding books and walking around slow), you split them into different rooms based on the author's last name (A-F, G-M, etc.). Each room is a "shard."
**System Design Interview Tips:** 
- Be prepared to discuss sharding keys (e.g., user_id) and the problem of uneven data distribution (hotspots).
- Explain consistent hashing to minimize data movement when adding or removing shards.

## 5. Denormalization
**Technical Definition:** Denormalization is a database optimization technique in which we add redundant data to one or more tables. This can help us avoid costly joins in a relational database.
**Real-world Analogy:** Instead of having to call your bank, your accountant, and your lawyer separately to get your financial status (normalizing), you keep a summary report on your desk that combines all the key info. It takes up a bit more space and needs updating, but it's much faster to read.
**System Design Interview Tips:** 
- Note that denormalization trades write performance and storage space for faster read performance.
- Discuss how you will keep the redundant data consistent (e.g., using background workers or triggers).

## 6. ACID
**Technical Definition:** ACID is an acronym for Atomicity, Consistency, Isolation, and Durability—a set of properties of database transactions intended to guarantee data validity despite errors, power failures, or other mishaps.
- **Atomicity:** All or nothing.
- **Consistency:** Brings database from one valid state to another.
- **Isolation:** Concurrent execution leaves the DB in the same state as if transactions were executed sequentially.
- **Durability:** Once committed, it remains committed.
**Real-world Analogy:** A bank transfer. If you send $100 to a friend, the system deducts $100 from your account and adds $100 to theirs. If the system crashes halfway, the whole transaction rolls back (Atomicity) so money isn't lost.
**System Design Interview Tips:** 
- Use ACID when dealing with financial transactions or systems where data integrity is paramount.
- Expect follow-up questions on isolation levels (Read Uncommitted, Read Committed, Repeatable Read, Serializable) and dirty reads.

## 7. BASE
**Technical Definition:** BASE stands for Basically Available, Soft state, Eventual consistency. It is a data system design philosophy that prizes availability over strict consistency, often used in NoSQL databases to achieve high scalability.
- **Basically Available:** The system guarantees availability.
- **Soft state:** The state of the system may change over time, even without input.
- **Eventual consistency:** The system will eventually become consistent once it stops receiving input.
**Real-world Analogy:** The "Like" count on a viral YouTube video. When you like it, the count might not immediately update for users in other countries (Eventual consistency), but the video keeps playing without errors (Basically Available).
**System Design Interview Tips:** 
- Contrast BASE with ACID.
- Discuss the CAP theorem when explaining why BASE is chosen (prioritizing Availability and Partition tolerance over strict Consistency).
