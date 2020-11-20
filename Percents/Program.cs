using System;

namespace DZ___ZKO
{
    class Program
    {
        public static double Calculate(string input)
        {
            string[] words = input.Split();
            double inputSum = double.Parse(words[0]);
            double percent = double.Parse(words[1]);
            double month = double.Parse(words[2]);

            double result = inputSum * Math.Pow(1.00 + (percent / 12 / 100), month);
            return result;
        }
        static void Main(string[] args)
        {
           string input =  Console.ReadLine();
           Console.WriteLine(Program.Calculate(input));
        }
    }
}
