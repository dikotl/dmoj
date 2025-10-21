using System;

static class Program
{
    static void Main()
    {
        string input;
        while ((input = Console.ReadLine() ?? "") != "")
        {
            var values = input.Split();
            var a = int.Parse(values[0]);
            var b = int.Parse(values[1]);
            Console.WriteLine(a + b);
        }
    }
}
