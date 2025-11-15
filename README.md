| Full Name        | ID          |
|----------------- |-------------|
| Betelhem Melesse | UGR/3224/15 |
| Meklit Tadie     | UGR/3049/15 |
| Solome Bereket   | UGR/3839/15 |





# Centralized Hotel Management System

## Overview
A **Centralized Hotel Management System** for multi-branch hotels to monitor and control operations. Provides:

- Real-time room availability & unified pricing  
- Food sales tracking & customer activity monitoring  
- Branch performance analytics  

Built with **DDD**, **Event-Driven Architecture**, **Modular Monolith → Microservices**, and AI for nutrition insights and inventory forecasting.

## Business Problem
Challenges in multi-branch hotels:

- No real-time visibility across branches  
- Inconsistent pricing & manual reporting  
- Hard to track customer behavior and popular foods  
- Inefficient resource management  

**Solution:** Centralized system consolidates branch data for timely, data-driven decisions.

## Subdomains
- **Core:** Central Operations & Transaction Management  
- **Supporting:** Customer Management  
- **Generic:** Authentication (Keycloak), Notifications, Shared Catalog  

## Bounded Contexts
- **Reservation & Pricing:** Bookings, room status, unified pricing (`RoomReserved`, `PriceUpdated`)  
- **Food & Beverage:** Menu items, sales, popularity (`FoodSold`)  
- **Branch Analytics:** Dashboards (occupancy, revenue, popular foods)  
- **Customer Management:** Guest profiles & visit history  

**Context Map:**  
- `Reservation → Analytics` (Event Streaming)  
- `Analytics → Customer Management` (ACL)  
- `All → Keycloak` (Shared Kernel)

## Key Use Cases / User Stories
1. Central office views real-time room availability  
2. Updates room/food pricing centrally  
3. Monitors branch performance, popular foods, and active customers  

**Consistency:** Asynchronous events with RabbitMQ/Kafka.

## AI Features
**Customer-Facing:** Nutritional info, allergens, healthier alternatives  
**Admin-Facing:** Inventory forecasting & alerts  

Example:
Chicken Burger: 520 kcal, contains gluten
Suggested alternative: Grilled Chicken Wrap (310 kcal)
Milk will run out in 1.5 days at Bole branch → reorder soon

## Architecture
**Phase 1 – Modular Monolith:** Separate modules per context, domain events internal  
**Phase 2 – Microservices:** Independent services, event streaming, eventual consistency

## Security
- Keycloak (OAuth2/OpenID Connect)  
- SSO & Role-Based Access Control (RBAC)  
- Angular SPA + secured backend APIs

## Summary
A **scalable, maintainable, enterprise-ready system** for centralized hotel management, using DDD, event-driven architecture, modular design, AI features, and secure access control.

