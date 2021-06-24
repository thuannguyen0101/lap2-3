using System;
using System.Collections;

namespace lab8_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] temperatures = new double[100];
            temperatures[0] = 20;
            temperatures[1] = 23;
            temperatures[2] = 30;
            Console.WriteLine(GreaterCount(temperatures, 25));
        }

        public static int GreaterCount(IEnumerable enumerable, double min)
        {
            var count = 0;
            foreach (var temperature in enumerable)
            {
                if ((double) temperature >= min)
                {
                    count++;
                }
            }
            return count;
        }
    }
}