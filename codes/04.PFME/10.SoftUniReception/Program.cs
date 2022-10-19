using System;

namespace _10.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            
            int hours = 0;
            int sum = employee1 + employee2 + employee3;


            while (numberOfStudents > 0)
            {
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }

                numberOfStudents -= sum;
                
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
