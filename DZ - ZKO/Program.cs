using System;

namespace DZ___ZKO
{
    class Program
    {
        public static double Calculate(string ipn)
        {
            double sum, pers = 0;
            double month = 0;
            string[] words = ipn.Split();
            sum = double.Parse(words[0]);
            pers = double.Parse(words[1]);
            month = double.Parse(words[2]);

            sum = Math.Pow(1.00 + (pers * 12 / 100), month);
            return sum;
        }
        static void Main(string[] args)
        {
           string ipn =  Console.ReadLine();
           Console.WriteLine(Program.Calculate(ipn));
        }
    }
}
