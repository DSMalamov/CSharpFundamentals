using System;
using System.Collections.Generic;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Student> students = new List<Student>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = cmdArg[0];
                string lastName = cmdArg[1];
                string age = cmdArg[2];
                string city = cmdArg[3];
                bool exist = false;

                Student student = new Student(firstName, lastName, age, city);
                foreach (var item in students)
                {
                    if (item.FirstName == student.FirstName && item.LastName == student.LastName)
                    {
                        item.Age = student.Age;
                        item.City = student.City;
                        exist = true;
                    }
                }
                if (!exist) 
                {
                    students.Add(student);
                }
                
            }

            string command1 = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                Student currStudent = students[i];

                if (currStudent.City == command1)
                {
                    Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName} is {currStudent.Age} years old.");
                }

            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, string age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }


    }
}
