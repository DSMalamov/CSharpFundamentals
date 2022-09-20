using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numStudents = int.Parse(Console.ReadLine());
            double ppLightsaber = double.Parse(Console.ReadLine());
            double ppRobe = double.Parse(Console.ReadLine());
            double ppBelt = double.Parse(Console.ReadLine());

            int freeBelts = numStudents / 6;
            double pfLightsabers = Math.Ceiling(numStudents * 1.1);
            double pffLightsaber = pfLightsabers * ppLightsaber;
            double pfRobes = numStudents * ppRobe;
            double pfBelts = (numStudents - freeBelts) * ppBelt;
            double totalSum = pfBelts + pffLightsaber + pfRobes;

            if (totalSum <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(budget * 1.0 - totalSum):f2}lv more.");
            }


        }
    }
}
