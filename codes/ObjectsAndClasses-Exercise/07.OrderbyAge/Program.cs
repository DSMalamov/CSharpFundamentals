using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderbyAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Person> listOfPeople= new List<Person>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArg[0];
                string iD = cmdArg[1];
                int age = int.Parse(cmdArg[2]);

                Person person = new Person(name, iD, age);

                if (IsIDAlreadyUsed(listOfPeople, iD))
                {
                    person.Age = age;
                    person.Name = name;
                }
                else
                {
                    listOfPeople.Add(person);
                }


            }

            foreach (Person person in listOfPeople.OrderBy(a => a.Age))
            {
                Console.WriteLine(person);
            }
        }

        static bool IsIDAlreadyUsed(List<Person> listOfPeople,string iD)
        {
            return listOfPeople.Any(i => i.ID == iD);
        }
    }

    public class Person
    {
        public Person (string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
