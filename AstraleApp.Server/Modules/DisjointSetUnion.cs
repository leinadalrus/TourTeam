namespace AstraleApp.Modules.Graphs
{
  class DisjointSetUnion
  {
    int[] _parent = new int[] { };
    int[] _file = new int[] { };

    void _makeSet(int v)
    {
      _parent[v] = v;
      _file[v] = 0;
    }

    int _findSet(int v)
    {
      if (v == _parent[v]) return v;
      return _parent[v] = _findSet(_parent[v]); // <|[v]| compressed optimisation
    }

    void _unionSets(int a, int b)
    {
      a = _findSet(a);
      b = _findSet(b);

      if (a != b)
      {
        if (_file[a] < _file[b]) (b, a) = (a, b); // use tuples to swap values
        if (_file[a] == _file[b]) _file[a]++;
        _parent[b] = a;
      }
    }
  }
}
