using System;

namespace _13.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int nlectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double maxTotalBonus = 0;
            int maxLectures = 0;

            for (int i = 0; i < students; i++)
            {
                int currlectures = int.Parse(Console.ReadLine());

                double currTotal = (double)currlectures / nlectures * (5 + bonus);

                if (currTotal > maxTotalBonus)
                {
                    maxTotalBonus = currTotal;
                    maxLectures = currlectures;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxTotalBonus)}.");
            Console.WriteLine($"The student has attended {maxLectures} lectures.");
        }
    }
}
