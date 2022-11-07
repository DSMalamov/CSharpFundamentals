using System;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string company = cmdArg[0];
                string empID = cmdArg[1];

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new List<string>();
                }

                if (!companies[company].Contains(empID))
                {
                    companies[company].Add(empID);
                }
            }

            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
