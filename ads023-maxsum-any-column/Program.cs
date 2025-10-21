using System;

static class Program
{
    static int N;
    static int M;
    static int[,] a;

    static void Main()
    {
        ReadInput();

        int answer = MaxSum();

        Console.WriteLine(answer);
    }

    static int MaxSum()
    {
        var answer = 0;

        for (int i = 0; i < N; ++i)
        {
            int maxValueIndex = 0;

            for (int j = 1; j < M; ++j)
            {
                if (a[i, j] > a[i, maxValueIndex])
                {
                    maxValueIndex = j;
                }
            }

            answer += a[i, maxValueIndex];
        }

        return answer;
    }

    static void ReadInput()
    {
        string[] numValues = Console.ReadLine().Split();

        N = int.Parse(numValues[0]);
        M = int.Parse(numValues[1]);
        a = new int[N, M];

        for (int i = 0; i < N; ++i)
        {
            string[] row = Console.ReadLine().Split();

            for (int j = 0; j < M; ++j)
            {
                a[i, j] = int.Parse(row[j]);
            }
        }
    }
}
