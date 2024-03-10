## Conchord-App

## Things you may want to cover:

- Versioning/Version Control
    
- System dependencies
    
- Configuration
    
- Database creation
    
- Database initialization
    
- How to run the test suite
    
- Services (job queues, cache servers, search engines, etc.)
    
- Deployment instructions

# CSV + G-Zip

- Combine CSV and G-Zip to have asynchronous streaming between compressed files with a backpressure handling implementation
  - Employ automation software for this implementation
  - These are generally requested with JSON API data and other SSL/TLS support willing to server request(s) using the "HTTPS" protocol
# Composition over Inheritance

- Composite
- Facade

## Content Delivery

1. Observer
2. Memento
  1. Most dynamic programming languages can't guarantee Memento's are persistent in both data and state.
3. Flyweight
4. Chain-of-Responsibility

# To-do

1. Model-view (resource-template) Controller routing
  1. Request-mapping
  2. JSON data response(s) & request(s)
2. Search Engine Optimisation
  1. Meta-data must reflect Business's name and purpose
  2. Geo-location data with Google Maps to content Page \[1] visibility/presence
3. Employ a web-service with little-to-no cost/expense overhead
  1. This'll have to be horizontal resource scaling, meaning having a small-scale computer-server on-site (or else we scale vertically with resources, i.e more computer-servers)
  2. Our alternative would be cloud-based hosting

###### Model-view controller routing

```Mermaid Model-view controller routing
flowchart TD
  A[ActivityReportController] -->|Route URI| B(ConfigRouter)
  B --> C{Main-thread process state changes}
  C -->|Update Model-views| D[Model-view Template]
  C -->|Show Template| E[Report to other routing state "Configs"]
  C -->|Teardown current configuration of state| F[Test-driven aspect]
```

###### Activity Report Class Diagram

```Mermaid ActivityReport Class Diagram
classDiagram
  class Ship{
    -ShipRepository shipRepository
    
    +Commander()
    note "Other class members are present here, but are hidden for demonstration"
    
    +Ship(ShipRepository shipRepository) void
  }

  note "No dependency injection for class variables"
  class ActivityReportModel{
    +Title() string
    +Description() string
    +Ship() Ship
  }

  note "Dependency injection for instance variables"
  class ActivityReportController{
    +Title(string title) string
    +Description(String description) string
    +Ships(Ship ship) List~Ship~
  }

  note "Make sure the values of these instance variables are deep-copied and saved inside an external save-state file"

  ActivityReportController *-- ActivityReportModel
  note "Composition denoted by asterisk/star"
  ActivityReportController ..> ActivityReportModel
  note "...and is a dependency"
```