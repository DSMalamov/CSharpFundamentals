using System;
using System.Text;

namespace _05._MultipluBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());
            var numsToString = new StringBuilder();

            if (number1 == "0" || number2 == 0)
            {
                Console.WriteLine("0");
                return;
            }
            int leftover = 0;

            for (int i = number1.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(number1[i].ToString());
                int multiply = currDigit * number2 + leftover;
                int result = multiply % 10;
                leftover = multiply / 10;
                numsToString.Insert(0, result); 
            }

            if (leftover > 0)
            {
                numsToString.Insert(0, leftover);
            }

            Console.WriteLine(numsToString.ToString());
        }
    }
}
