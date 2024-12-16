# Service Layers

- a level of abstraction for business logic
- allows all logic related to a module to be implemented
- removes concerns from controller
  - controllers should only focus on directed web traffic
- includes a contract (interface) and an implementation (class)
- all dependencies for a module get injected in the service layer

# The Repository Pattern

- used to abstract data access
- typically used within the `Service Layer` to handle data retreival and 
  persistence
- All data-related operations are hidden from other layers
- Each repository is only responsible for a single model/table


# Unit-of-Work Pattern

- A behavioral pattern when dealing with multiple data-related operations
- When operations are finished, it should be considered all-or-nothing 
  meaning everything should be successful. If not, it should fail.
  - Like a db transaction
- Helps maintain ACID principles in a database


## Service Layer Dependency Injection

- Need to configure the `IoC` container (`program.cs` in this project) with 
  the classes participating in dep inj.
- The `IoC` container decides whether to return a new instance of a service 
  or use an existing one. This is decided by the type of registration used.

# Service Layer Registration Types

There are 3 different types to register a service.

# Transient

Services are created each time they are requested. Best for lightweight and 
stateless services. (Ex: API socket to make API calls)

# Scoped

Services are created once per request.

# Singleton

Services are created once and then reused by every request until the 
application stops.