using System;
using System.Linq;

static class Program
{
    struct Student
    {
        public int Class;
        public char ClassLetter;
        public string FirstName, LastName, BirthDate;
    }

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var sorted = new Student[n];

        for (int i = 0; i < n; i++)
        {
            var lastName = Console.ReadLine().Trim();
            var firstName = Console.ReadLine().Trim();
            var class_ = Console.ReadLine().Trim();
            var birthDate = Console.ReadLine().Trim();

            sorted[i] = new Student
            {
                LastName = lastName,
                FirstName = firstName,
                Class = int.Parse(class_.Substring(0, class_.Length - 1)),
                ClassLetter = class_[class_.Length - 1],
                BirthDate = birthDate,
            };
        }

        sorted = sorted
            .OrderBy(s => s.Class)
            .ThenBy(s => s.ClassLetter)
            .ThenBy(s => s.LastName)
            .ToArray();

        foreach (var student in sorted)
        {
            Console.WriteLine($"{student.Class}{student.ClassLetter} {student.LastName} {student.FirstName} {student.BirthDate}");
        }
    }
}
