using System;
using System.Collections.Generic;

namespace TransitiveClosure
{
    public class BFS : ISearch
    {
        private static bool[] _visited;
        private static Queue<int> _queue;
        public void search(int[,] array, int vertex, ISearch.Process process)
        {
            _queue = new Queue<int>();
            _visited = new bool[array.GetLength(0)];
            _visited[vertex] = true;
            process(vertex, vertex);
            _queue.Enqueue(vertex);
            Console.WriteLine(vertex + 1);
            while (_queue.Count > 0)
            {
                int v = _queue.Dequeue();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (!_visited[i] && array[v, i] > 0)
                    {
                        Console.WriteLine(i + 1);
                        _queue.Enqueue(i);
                        _visited[i] = true;
                        process(vertex, i);
                    }
                }
            }
        }
    }
}