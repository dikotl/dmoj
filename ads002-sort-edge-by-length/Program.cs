using System;
using System.Collections.Generic;
using System.Linq;

static class Program
{
    struct Edge
    {
        public int u, v, idx;
    }

    static void Main()
    {
        var lenToEdge = ReadInput();

        foreach (var pair in lenToEdge)
        {
            var len = pair.Key;
            var edge = pair.Value;

            Console.WriteLine($"{edge.u} {edge.v} {len} {edge.idx}");
        }
    }

    static SortedDictionary<int, Edge> ReadInput()
    {
        var numValues = Console.ReadLine().Split();
        var M = int.Parse(numValues[1]);
        var lenToEdge = new SortedDictionary<int, Edge>();

        for (var i = 0; i < M; ++i)
        {
            var value = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            lenToEdge.Add(value[2], new Edge
            {
                u = value[0],
                v = value[1],
                idx = i + 1,
            });
        }

        return lenToEdge;
    }
}
