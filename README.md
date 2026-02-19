🚀 Dotnet_API_15_APIConnect-Hub

A structured .NET Web API project demonstrating efficient API-to-API communication using HttpClient along with In-Memory Caching to optimize performance and reduce repeated external calls.

📌 Project Overview

This project acts as a Hub API that:

Consumes another API using HttpClient

Implements asynchronous communication

Applies In-Memory Caching for faster reload

Uses DTOs for clean response mapping

Follows a clean layered architecture

The main objective is to demonstrate how backend systems communicate securely and efficiently while maintaining high performance.

🔁 API-to-API Communication

The project uses HttpClient to call a second API from within the primary API.

Flow:
Client → Hub API → HttpClient → External API → Response → Hub API → Client


Key Highlights:

Asynchronous HTTP calls

Structured response handling

Proper error handling

Clean separation of service logic

This demonstrates real-world backend integration patterns used in microservices and distributed systems.

⚡ In-Memory Caching Implementation

To improve performance, the project uses IMemoryCache.

Pattern Used:

Cache Aside Pattern

Flow:

Check if data exists in cache

If found → return cached data

If not found → call DB / External API

Store result in cache

Return response

Benefits:

Reduces repeated database/API calls

Improves response time

Reduces server load

Enhances scalability

Example usage:

await cache.GetOrSetAsync(
    "player_list",
    async () => await _context.Players.ToListAsync(),
    TimeSpan.FromMinutes(5)
);

🧠 Why Caching Was Implemented

Without caching:

Every request hits the database or external API

Increased latency

Higher infrastructure load

With caching:

Faster repeated responses

Lower database pressure

Optimized backend performance

🛠 Technologies Used

.NET Web API

Entity Framework Core

HttpClient

IMemoryCache

Dependency Injection

LINQ

DTO Pattern

🧩 Design Principles Applied

Layered Architecture

Dependency Injection

Cache Aside Pattern

Clean Separation of Concerns

Async/Await for non-blocking operations

🧪 How to Verify Caching

First request triggers DB/API call

Subsequent requests are served from cache

Reduced response time confirms cache hit

Cache expiration configurable using TimeSpan

🚀 Future Enhancements

Upgrade to Redis (Distributed Caching)

Implement retry policies using Polly

Add structured logging

Add authentication & authorization

Containerize using Docker

Deploy to Azure

🎯 Key Learning Outcomes

Implementing API orchestration using HttpClient

Optimizing backend performance using caching

Applying clean architecture principles

Understanding distributed communication patterns

Designing scalable backend systems
