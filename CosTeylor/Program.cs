using System;

namespace CosTeylor
{
    internal class Program
    {
        static double Factorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }

        public static double Cos(double x, int n = 0, double E = 0.005)
        {
            double Sum = 0;
            while (true)
            {
                var t = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial((2 * n));
                
                if (Math.Abs(t) < E)
                {
                    return Sum;
                }
                else
                {
                    Sum += t;
                    n++;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("x = ");
            var x = double.Parse(Console.ReadLine());
            var result = Cos(x);
            Console.WriteLine("Cos(x)      = {0:f6}", result);
            Console.WriteLine("Math.Cos(x) = {0:f6}", Math.Cos(x));
        }
    }
}