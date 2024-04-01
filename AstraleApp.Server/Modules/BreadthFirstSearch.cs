namespace AstraleApp.Modules.Graphs
{
  class BreadthFirstSearch
  {
    Chord _chord;

    BreadthFirstSearch(Chord chord, int[][] graph)
    {
      _chord = chord;
      _chord.Predecessor = new Chord();
      _chord.Successor = _chord.Predecessor;

      Queue<int> queue = new Queue<int>();
      bool[] hasVisited = new bool[_chord.Vertex];

      while (!hasVisited[_chord.Vertex])
      {
        foreach (int vertex in graph[_chord.Vertex])
        {
          queue.Enqueue(vertex);

          if (!hasVisited[vertex])
          {
            queue.Enqueue(vertex);
            hasVisited[vertex] = true;
          }
        }
      }
    }
  }

  class Chord
  {
    public Chord() {}

    public Chord? Predecessor = null;
    public Chord? Successor = null; // minimum number of edges for vertices
    public int Vertex = 0;
  }
}
//
// Constraints:
// m == grid.length
// n == grid[i].length
// 1 <= m, n <= 50
// grid[i][j] is either 0 or 1.
//