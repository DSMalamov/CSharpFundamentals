using System;
using System.Collections.Generic;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string course = cmdArg[0];
                string student = cmdArg[1];

                if (!courses.ContainsKey(course))
                {
                    courses[course] = new List<string>();

                }

                courses[course].Add(student);
            }

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var st in item.Value)
                {
                    Console.WriteLine($"-- {st}");
                }
            }
        }
    }
}
