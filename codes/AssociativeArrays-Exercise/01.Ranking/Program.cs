using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var submissions = new Dictionary<string, Dictionary<string, int>>();

            string command;

            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] cmdArg = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                string contest = cmdArg[0];
                string password = cmdArg[1];

                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = password;
                }
            }

            command = Console.ReadLine();

            while (command != "end of submissions")
            {
                string[] cmdArg = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contestOfSub = cmdArg[0];
                string passOfSub = cmdArg[1];
                string username = cmdArg[2];
                int points = int.Parse(cmdArg[3]);

                if (contests.ContainsKey(contestOfSub) && contests[contestOfSub] == passOfSub)
                {
                    if (!submissions.ContainsKey(username))
                    {
                        submissions[username] = new Dictionary<string, int>();
                    }

                    if (submissions.ContainsKey(username) && !submissions[username].ContainsKey(contestOfSub))
                    {
                        submissions[username][contestOfSub] = 0;
                    }

                    if (submissions[username][contestOfSub] < points)
                    {
                        submissions[username][contestOfSub] = points;
                    }
                }

                command= Console.ReadLine();
            }

            string winner = submissions.OrderBy(x => x.Value.Values.Sum()).Last().Key;
            int bestPoints = submissions.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum();

            Console.WriteLine($"Best candidate is {winner} with total {bestPoints} points.");

            Console.WriteLine("Ranking:");

            foreach (var item in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var contest in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        
        }
    }
}
