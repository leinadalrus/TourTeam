## MVC with Vue

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

## In detail: ...

1. Model-view Controller Routing: Configuration
  - Add a Controller
  - Add a View
  -  Add a Model
2. Work with a Database
  - Controller Actions and Views: in correspondence
    - Add a Search
    - Add a New Field
    - Add Validation
3. Examine Details and Delete Methods

###### _Model-view controller routing_

```Mermaid Model-view controller routing
flowchart TD
  A[ActivityReportController] -->|Route URI| B(ConfigRouter)
  B --> C{Main-thread process state changes}
  C -->|Update Model-views| D[Model-view Template]
  C -->|Show Template| E[Report to other routing state "Configs"]
  C -->|Teardown current configuration of state| F[Test-driven aspect]
```

###### _Activity Report Class Diagram_

```Mermaid ActivityReport Class Diagram
classDiagram
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

###### _Division Commander Class Diagram_

```Mermaid Division Commander Diagram
classDiagram
  class DivisionCommander{
    -CommanderRepository commandRepository
    +DivisionCommander()
  }
```

###### _Division Staff Class Diagram_

```Mermaid Division Staff Diagram
classDiagram
  class DivisionStaff{
    -StaffRepository staffRepository
    +DivisionStaff(List~DivisionStaff~ staff)
  }
```

###### _Ship Class Diagram_

```Mermaid Ship Class Diagram
  class Ship{
    -ShipRepository shipRepository
    
    +DivisionCommander()
    note "Other class members are present here, but are hidden for demonstration"
    
    +Ship(ShipRepository shipRepository) void
  }
```

