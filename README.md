## A small-business e-commerce content management system

## Things you may want to cover

- Versioning/Version Control
    
- System dependencies
    
- Configuration
    
- Database creation
    
- Database initialization
    
- How to run the test suite
    
- Services (job queues, cache servers, search engines, etc.)
    
- Deployment instructions

## Things you may want to consider

_Composition over inheritance design patterns_

1. Composite
2. Facade

_Content delivery design patterns_

1. Observer
2. Memento
    1. Most dynamic programming languages can't guarantee Memento's are persistent in both data and state.
3. Flyweight
4. Chain-of-Responsibility

# To-do

_Front-end_

1. [ ] Search Bar Mastery
2. [ ] Social Banner
3. [ ] 3D Graph Replica
4. [ ] Liquid Button
5. [ ] Tool Tip

_Back-end_

1. Model-View (resource-template) Controller routing
    - Request-mapping
    - JSON data response(s) & request(s)
2. Search Engine Optimisation
    - Meta-data must reflect Business's name and purpose
    - Geo-location data with Google Maps to content Page \[1] visibility/presence
3. Employ a web-service with little-to-no cost/expense overhead
    -  This'll have to be horizontal resource scaling, meaning having a small-scale computer-server on-site (or else we scale vertically with resources, i.e more computer-servers)
    - Our alternative would be cloud-based hosting

#### _In detail..._

1. Model-view Controller Routing: Configuration
    - Add a Controller
    - Add a View
    -  Add a Model
2. Work with a Database
    - Controller actions and views in correspondence
        - Add a Search
        - Add a New Field
        - Add Validation
3. Examine Details and Delete Methods

#### Example diagrams
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
    +Vehicle() Vehicle
  }

  note "Dependency injection for instance variables"
  class ActivityReportController{
    +Title(string title) string
    +Description(String description) string
    +Vehicles(Vehicle ship) List~Vehicle~
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

###### _Vehicle Class Diagram_

```Mermaid Vehicle Class Diagram
  class Vehicle{
    -VehicleRepository shipRepository
    
    +DivisionCommander()
    note "Other class members are present here, but are hidden for demonstration"
    
    +Vehicle(VehicleRepository shipRepository) void
  }
```

# Milestones

- HTTP Request and Response:
    - Reading and writing JSON files
- Reactive/responsive feature components

1. [ ] Content Management System with trading cards
2. [ ] Inventory Management System
3. [ ] Point-of-Sales system
4. [ ] Complementary adjacent preview pane
5. [ ] Modal component view
6. [ ] Search engine and search engine optimisation
7. [ ] Graphics programming with Three.js

With this system, it works like a file explorer but with less visual acuity or context-loss.

So in a sense, a data-driven Inventory Management System must be influenced by the systemic design of database tables in order to imitate real-world object.
# Milestone I: Sprint I

#### Feature Component: Trading Card

- Re-stylise Trading Card
    - Centre Trading Card layering styles
    - Isolate styling code from other components/classes
    - Implement Drag-and-Drop functionality

1. Grid-map Container should be centred via `50vh` and `50vw`
    - Trading Card must then follow suit as a `slot` or `ng-content`
2. Trading Card
    - Word-search algorithm but with damage and armour based values
    - Grouped subset algorithm for batch processing
3. File-system
    - Mementos
    - Binary Tree
4. Login Console
    - House keeping

- Database configuration and interfacing with an ORM (a-la LINQ)

# TODO
#TODO

1. Create, read, update, destroy forms
    1. Pipeline, via checkpoints publication form progress
    2. Have a means to undo workload
2. Box align format cards for homepage & dashboard
3. Add-to-cart system into self-checkout modal-dialog
4. View and manage recent transactions

#### Back-end mechanics: CSV and G-Zip

- Combine CSV and G-Zip to have asynchronous streaming between compressed files with a backpressure handling implementation
    - Employ automation software for this implementation
    - These are generally requested with JSON API data and other SSL/TLS support willing to server request(s) using the "HTTPS" protocol
