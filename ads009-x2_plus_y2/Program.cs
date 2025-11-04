using System;

static class Program
{
    static void Main()
    {
        var n = long.Parse(Console.ReadLine());

        for (long x = 1; x <= Math.Sqrt(n); x++)
        {
            var ySquared = n - x * x;
            var y = (long)Math.Sqrt(ySquared);

            if (y > 0 && y * y == ySquared)
            {
                Console.WriteLine($"{x} {y}");
            }
        }
    }
}
