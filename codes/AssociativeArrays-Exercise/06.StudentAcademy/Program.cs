using System;
using System.Collections.Generic;

namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = grade;
                }
                else
                {
                    students[name] += grade;
                    students[name] /= 2;
                }
            }

            foreach (var kvp in students)
            {
                if (kvp.Value >= 4.5)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
                }
            }
        }
    }
}
