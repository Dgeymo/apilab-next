# ApiLab Next

> Next‑gen API testing & real-time monitoring platform

ApiLab Next is a developer-focused platform designed to simplify how APIs are tested, analyzed and monitored.

Instead of using multiple disconnected tools (Swagger, Postman, stress testing tools, logs dashboards), ApiLab Next brings everything together into a single, cohesive experience.

---

## Motivation

When working with client–server architectures, developers often face a fragmented workflow:

- Swagger → documentation & basic testing  
- Postman → request execution  
- k6 / JMeter → stress testing  
- Logs → debugging  

This fragmentation slows down development and reduces visibility.

**ApiLab Next aims to unify these workflows in one place.**

---

## Features

### API Discovery (OpenAPI / Swagger)
- Automatically reads and parses your API structure
- Generates endpoints dynamically (no manual setup)

---

### Endpoint Execution
- Run individual endpoints with custom parameters
- Inspect response status, body and response time

---

### Run All
- Execute all available endpoints in one action
- Quickly detect broken or slow endpoints

---

### Smart Data Generation
- Generate random and realistic input data
- Useful for testing edge cases and avoiding manual setup

---

### Stress & Concurrency Testing
- Simulate multiple requests in parallel
- Configure number of requests and concurrency level
- Identify performance bottlenecks

---

### Real-Time Monitoring
- Live request tracking using WebSockets / SignalR
- Visual feedback of:
  - response times
  - errors
  - throughput

---

## Architecture Overview

ApiLab Next is built as a modular platform:
Frontend (Dashboard)
↓
Executor / Testing Engine
↓
Backend (Middleware)
↓
Real-time events (SignalR)
↓
Live Monitoring Dashboard

### Components:

- **Discovery module** → parses OpenAPI specs  
- **Executor** → runs requests (single, batch, stress)  
- **Middleware** → captures request metadata  
- **Real-time engine** → pushes events to UI  
- **Dashboard** → visualizes everything live  

---

## Tech Stack

### Backend
- .NET / ASP.NET Core
- SignalR
- HttpClient

### Frontend
- React
- WebSockets / SignalR client

---

## Roadmap

- [x] Project setup
- [ ] OpenAPI parsing
- [ ] Endpoint execution (manual)
- [ ] Run All feature
- [ ] Random data generator
- [ ] Stress testing module
- [ ] Real-time dashboard
- [ ] UI improvements

---

## Example Use Cases

- Quickly verify all endpoints before deploy  
- Detect slow APIs under load  
- Simulate real client behavior with concurrent requests  
- Monitor API activity in real time during development  

---

## Getting Started

> Project is currently under active development

Clone the repository:

```bash
git clone https://github.com/your-username/apilab-next.git
cd apilab-next
```
Setup instructions will be added as the project evolves.

# License
This project is licensed under the MIT License.

# Author
Diego Geymonat
Student of Information Technologies – ORT Uruguay

