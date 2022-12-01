using System;

namespace TransitiveClosure
{
    public class DFS : ISearch
    {
        private static bool[] visited;

        public DFS()
        {
            visited = new bool[4];
        }
        
        public void search(int[,] array, int vertex, ISearch.Process process)
        {
            
            visited[vertex] = true;
            process(vertex, vertex);
            Console.Out.WriteLine(vertex + 1);
            for (int i = 0; i < array.GetLength(0); i++) {
                if (array[vertex, i] != 0 && !visited[i] )
                {
                    
                    search(array, i, process);
                    process(vertex, i);
                }
            }

        }
    }
}