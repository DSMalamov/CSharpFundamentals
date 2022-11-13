using System;

namespace _12.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            string output = string.Empty;

            foreach (var item in input)
            {
                if (item == ".-")
                {
                    output += "A";
                }
                else if (item == "-...")
                {
                    output += "B";
                }
                else if (item == "-.-.")
                {
                    output += "C";
                }
                else if (item == "-..")
                {
                    output += "D";
                }
                else if (item == ".")
                {
                    output += "E";
                }
                else if (item == "..-.")
                {
                    output += "F";
                }
                else if (item == "--.")
                {
                    output += "G";
                }
                else if (item == "....")
                {
                    output += "H";
                }
                else if (item == "..")
                {
                    output += "I";
                }
                else if (item == ".---")
                {
                    output += "J";
                }
                else if (item == "-.-")
                {
                    output += "K";
                }
                else if (item == ".-..")
                {
                    output += "L";
                }
                else if (item == "--")
                {
                    output += "M";
                }
                else if (item == "-.")
                {
                    output += "N";
                }
                else if (item == "---")
                {
                    output += "O";
                }
                else if (item == ".--.")
                {
                    output += "P";
                }
                else if (item == "--.-")
                {
                    output += "Q";
                }
                else if (item == ".-.")
                {
                    output += "R";
                }
                else if (item == "...")
                {
                    output += "S";
                }
                else if (item == "-")
                {
                    output += "T";
                }
                else if (item == "..-")
                {
                    output += "U";
                }
                else if (item == "...-")
                {
                    output += "V";
                }
                else if (item == ".--")
                {
                    output += "W";
                }
                else if (item == "-..-")
                {
                    output += "X";
                }
                else if (item == "-.--")
                {
                    output += "Y";
                }
                else if (item == "--..")
                {
                    output += "Z";
                }
                else if (item == "|")
                {
                    output += " ";
                }

            }
            Console.WriteLine(output);
        }
    }
}
