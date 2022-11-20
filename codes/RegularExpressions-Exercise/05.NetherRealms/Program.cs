using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<health>[^\d\+\-\*\/\.]+)(?<damage>[-]?\d([.\d]+)?)*(?<action>[\*|\/]*)";

            Regex regex = new Regex(pattern);

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string currEl = input[i];
                MatchCollection match = regex.Matches(currEl);

                var currHealth = new StringBuilder();
                List<double> currAttack = new List<double>();
                var currAction = new StringBuilder();

                foreach (Match item in match)
                {

                    string chealth = item.Groups["health"].Value;
                    currHealth.Append(chealth);
                    string cattack = item.Groups["damage"].Value;
                    if (cattack != String.Empty)
                    {
                        currAttack.Add(double.Parse(cattack));
                    }
                    string caction = item.Groups["action"].Value;
                    currAction.Append(caction);
                }

                int totalHp = TotalHealth(currHealth);
                double totalAtk = TotalAtack(currAttack, currAction);

                Console.WriteLine($"{currEl} - {totalHp} health, {totalAtk:f2} damage");
            }



        }

        private static int TotalHealth(StringBuilder currHealth)
        {
            int totalHp = 0;
            foreach (char hpCh in currHealth.ToString())
            {
                totalHp += hpCh;
            }
            return totalHp;
        }

        private static double TotalAtack(List<double> currAttack, StringBuilder currAction)
        {
            double totalAtk = 0;
            foreach (var item in currAttack)
            {
                totalAtk += item;
            }

            foreach (var item in currAction.ToString())
            {
                if (item == '*')
                {
                    totalAtk *= 2;
                }
                else if (item == '/')
                {
                    totalAtk /= 2;
                }
            }
            return totalAtk;
        }
    }
}
