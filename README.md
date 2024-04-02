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

# Sprint 1: Milestone 1
###### _Skuxx-life..._

With `v-bind` we need to develop our Vue Components from a top-down approach:

Where we grab the `ref` values from the Document Object Model (DOM) -

```TypeScript
const uuid = ref(0)
```

- Employing the `watch` function from Vue:

```TypeScript
// ... const uuid = ref(0)
// goes into: ...
watch(uuid, () => {})
```

- And then it reflects in the template syntax within Vue.

```HTML
<article v-bind:uuid="id">ID</article>
```

Then we should have an HTML article which works hand-in-hand from TypeScript to Vue templating syntax.

#### Feature Component: Trading Card

- Re-stylise Trading Card
  - Centre Trading Card layering styles
  - Isolate styling code from other SFC (Single File Component)
- Implement Drag-and-Drop functionality

1. Grid-map Container should be centred via `50vh` and `50vw`
  - Trading Card SFC must then follow suit as a `slot`
2. Trading Card
  - Word-search algorithm but with damage and armour based values
    - Grouped subset algorithm for batch processing
3. File-system
  - Mementos
    - Binary Tree - algorithms

# Algorithms
## In-tandem With Another

1. Arrays-&-Hashing
  - Contains Duplicate
  - Product of Array except Self
  - Encode and Decode Strings
2. Two Pointers
- Two Sum II Input Array Is Sorted
- Container With Most Water
- Trapping Rain Water
3. Stack
- Valid Parentheses
- Generate Parentheses
- Min Stack
- Evaluate Reverse Polish Notation
- Largest Rectangle In Histogram
4. Binary Search
- Search a 2D Matrix
- Find Minimum In Rotated Sorted Array
- Search In Rotated Sorted Array
- Time Based Key Value Store
5. Sliding Window
- Longest Substring Without Repeating Characters
- Longest Repeating Character Replacement
- Minimum Window Substring
- Sliding Window Maximum
6. Linked List
- Merge K Sorted Lists
- Reverse Nodes in K Group
- LRU Cache
7. Trees
- Invert Binary Tree
- Maximum Depth Binary Tree
- Subtree of Another Tree
- Construct Binary Tree From Pre-order and In-order Traversal
- Serialise and Deserialize Binary Tree
8. Backtracking
- Word Search
- Subsets
- Permutations
9. Graphs
- Number of Islands
- Clone Graph
- Max Area of Island
- Surrounded Regions
- Walls and Gates
- Number of Connected Components in an Undirected Graph
- Redundant Connection
10. Advanced Graphs
- Network Delay Time
- Reconstruct Itinerary
- Swim in Rising Water

#### Housekeeping: Login Console (SFC)
###### Database Configuration and Interfacing: with an ORM (a-la LINQ)


``` C# Islands.cs
public int MaxAreaOfIsland(int[][] grid)
{
  int m = grid.Length,
      n = grid[0].Length;
  // outside values which should be in a `Queue<int>()` value;

  if (1 <= m && n <= m)
      return n;
  
  return m;
}

private int _breadthFirstSearch(int[][] grid)
{
  Chord chord = new Chord();
  chord._predecessor = new Chord();
  chord._distance = chord._predecessor;
      
  bool[] hasVisited = new bool[chord._edge];

  while (!hasVisited[chord._edge])
  {
      for (int i = 0; i < grid.Length; ++i)
      {
          for (int j = 0; j < grid[0].Length; ++j)
          {
              hasVisited[j] = true;
              chord._edge = j;

              return _breadthFirstSearch(grid);
          }
      }
  }

  return _breadthFirstSearch(grid);
}
```

``` C# Chord.cs
class Chord
{
  Chord() {}
  Chord _predecessor;
  Chord _distance;
  int _edge;
}
```