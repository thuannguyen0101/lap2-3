using System;
using System.Collections.Generic;

namespace lab8_2
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            List<int> nhietdos = new List<int>();
            nhietdos.Add(30);
            nhietdos.Add(20);
            nhietdos.Add(25);
            nhietdos.Add(40);
            nhietdos.Add(35);
            var count = 0;
            foreach (var nhietdo in nhietdos)
            {
                if (nhietdo >= 25)
                {
                    count++;
                }
            }

            Console.WriteLine("Number of temperatures that equal or exceed 25 degrees are:"+ count);
            Console.WriteLine("Number of temperatures that equal  or exceed 30 degrees are:"+ GreaterCount(nhietdos,30));
        }
        public static int GreaterCount(List<int> list, double min)
        {
            var count = 0;
            foreach (var temperature in list)
            {
                if (temperature >= min)
                {
                    count++;
                }
            }

            return count;
        }
    }
}