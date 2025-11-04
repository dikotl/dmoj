using System;
using System.Collections.Generic;

static class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var set = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            switch (input[0])
            {
            case "ADD":
                set.Add(int.Parse(input[1]));
                break;

            case "PRESENT":
                Console.WriteLine(
                    set.Contains(int.Parse(input[1]))
                        ? "YES"
                        : "NO"
                );
                break;

            case "COUNT":
                Console.WriteLine(set.Count);
                break;
            }
        }
    }
}
