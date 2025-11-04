using System;
using System.Collections.Generic;

static class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var clients = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            switch (input[0])
            {
            case "1":
            {
                var name = input[1];
                var value = int.Parse(input[2]);
                clients[name] = clients.GetValueOrDefault(name) + value;
            }
            break;

            case "2":
            {
                if (clients.TryGetValue(input[1], out int value))
                {
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
            break;
            }
        }
    }
}
