using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double pHeadset = double.Parse(Console.ReadLine());
            double pMouse = double.Parse(Console.ReadLine());
            double pKeyboard = double.Parse(Console.ReadLine());
            double pDisplay = double.Parse(Console.ReadLine());

            int brokenH = lostGames / 2;
            int brokenM = lostGames / 3;
            int brokenK = lostGames / 6;
            int brokenD = lostGames / 12;

            double totalP = pHeadset * brokenH + pMouse * brokenM + pKeyboard * brokenK + pDisplay * brokenD;
            Console.WriteLine($"Rage expenses: {totalP:f2} lv.");
        }
    }
}
