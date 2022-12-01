using System;

namespace TransitiveClosure.App
{
    internal class Program
    {
        private static ISearch.Process _process = (i, j) =>
        {
            transiniveClosure[i, j] = 1;
        };

        private static int primary = 0;
        
        private static ISearch.Process _processDfs = _process + ((i, j) =>
        {
            transiniveClosure[primary, j] = 1;
            
        });
        static int[,] array = {
          {0, 1, 0, 0},
          {0, 0, 0, 1},
          {0, 0, 0, 0},
          {1, 0, 1, 0},
        };
        static int[,] transiniveClosure = new int[4,4];
        private static bool[] visited = new bool[4];
        public static void Main(string[] args)
        {
           
            visited = new bool[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                ISearch search = new BFS();
                primary = i;
                visited = new bool[array.GetLength(0)];
                search.search(array, i, _processDfs); 
            }

            for (int i = 0; i < transiniveClosure.GetLength(0); i++)
            {
                for (int j = 0; j < transiniveClosure.GetLength(0); j++)
                {
                    Console.Write(transiniveClosure[i, j]);

                }
                Console.WriteLine();
            }
        }

       
    }
}