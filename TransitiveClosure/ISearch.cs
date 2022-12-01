using System;

namespace TransitiveClosure
{
    public interface ISearch
    {
        void search(int[,] array, int vertex, Process process);

        delegate void Process(int i, int j);
    }
}