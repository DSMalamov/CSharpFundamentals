using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = cmdArg[0];
                string lastName = cmdArg[1];
                double grade = double.Parse(cmdArg[2]);

                Student currStudent = new Student(firstName, lastName, grade);
                students.Add(currStudent);
            }

            foreach (var item in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Grade { get; private set; }
    }
}
