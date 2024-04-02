namespace AstraleApp.Modules.Graphs
{
  class BreadthFirstSearch
  {
    private Chord _chord;

    public BreadthFirstSearch(Chord chord)
    {
      _chord = chord;
    }

    private int _maxAreaofIsland(int[][] graph)
    {
      int m = graph.Length,
          n = graph[0].Length;
      // outside values which should be in a `Queue<int>()` value;

      if (1 <= m && n <= m)
          return n;
  
      return m;
    }

    private int _breadthFirstSearch(int[][] graph)
    {
      this._chord.Predecessor = new Chord();
      this._chord.Distance = this._chord.Predecessor;
          
      bool[] hasVisited = new bool[this._chord.Predecessor.Edge];
    
      while (!hasVisited[this._chord.Predecessor.Edge])
      {
        foreach (int i in graph[this._chord.Distance.Edge])
        {
          hasVisited[i] = true;
          this._chord.Edge = i;
    
          return _breadthFirstSearch(graph);
        }
      }
    
      return _breadthFirstSearch(graph);
    }
  }

  class Chord
  {
    public Chord() {}

    public Chord? Predecessor = null;
    public Chord? Distance = null; // minimum number of edges for vertices
    public int Edge = 0;
  }
}