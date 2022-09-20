using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int wrongPass = 1;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currCh = username[i];
                password += currCh;
            }
            string currPass = Console.ReadLine();
            
            while (true)
            {
                
                if (currPass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                if (wrongPass >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    Environment.Exit(0);
                }
                wrongPass++;

                if (currPass != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                currPass = Console.ReadLine();
                
            }
        }
    }
}
