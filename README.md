Tech Test: Mini Service Builder (2-Hour Limit)

Overview

We’d like you to build a small backend service that demonstrates how you approach writing maintainable code, structuring a simple system, and making sensible engineering trade-offs under time constraints.

We are less interested in completeness and more interested in clarity, structure, and decision-making.

Scenario

You are building a simple Task Management Service for an internal team.

The service should allow users to:

Create tasks
List tasks
Mark tasks as complete
Requirements

1. Create Task

A task should include:

id (auto-generated)
title (required)
description (optional)
status (default: "open")
createdAt
2. List Tasks

Return all tasks, with optional filtering by:

status (open / complete)
3. Complete Task

Mark a task as “complete” by id.

Constraints

Use any language or framework you are comfortable with
In-memory storage is sufficient (no database required)
Keep the solution lightweight (avoid over-engineering)
You may use libraries, but be prepared to explain your choices
Time Expectation

Aim to spend no more than 2 hours
If you do not finish, include notes on what you would complete next
 

 

Discussion in Interview

We will review your solution and may ask:

How would you evolve this into a production-ready service?
Where would you introduce persistence (e.g. a database) and why?
What would you change if the system needed to scale significantly?
How would you assign this work in a small team?
What would you improve with more time?
 
