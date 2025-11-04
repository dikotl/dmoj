using System;
using System.Collections.Generic;

static class Program
{
    static int N;
    static int M;
    static long[,] a;
    static long answer = -1;

    static void Main()
    {
        ReadInput();

        for (int j = 0; j < M; ++j)
        {
            Do(0, j, 0);
        }

        Console.WriteLine(answer == -1 ? "impossible" : $"{answer}");
    }

    static void ReadInput()
    {
        var numValues = Console.ReadLine().Split();

        N = int.Parse(numValues[0]);
        M = int.Parse(numValues[1]);
        a = new long[N, M];

        for (var i = 0; i < N; ++i)
        {
            var row = Console.ReadLine().Split();

            for (var j = 0; j < M; ++j)
            {
                a[i, j] = long.Parse(row[j]);
            }
        }
    }

    static void Do(int i, int j, long sum)
    {
        if (i < 0 || i >= N || j < 0 || j >= M)
        {
            // Out of range.
            return;
        }

        sum += a[i, j];

        // For the last row, check is sum is lucky.
        if (i == N - 1)
        {
            if (IsLucky(sum))
            {
                answer = Math.Max(answer, sum);
            }
            return;
        }

        // Check next row neighbors.
        Do(i + 1, j - 1, sum);
        Do(i + 1, j, sum);
        Do(i + 1, j + 1, sum);
    }

    static bool IsLucky(long x)
    {
        if (x == 0)
        {
            return false;
        }
        while (x > 0)
        {
            var d = x % 10;
            if (d != 4 && d != 7)
            {
                return false;
            }
            x /= 10;
        }
        return true;
    }
}
