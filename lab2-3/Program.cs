using System;

namespace lab2_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("SIN Validator\n=============");
                Console.WriteLine("SIN (0 to quit):"); string s = Console.ReadLine(); 
                if (s.Length == 9)
                {
                    int a = int.Parse(s.Substring(0, 1));
                    int b = int.Parse(s.Substring(1, 1));
                    int c = int.Parse(s.Substring(2, 1));
                    int d = int.Parse(s.Substring(3, 1));
                    int e = int.Parse(s.Substring(4, 1));
                    int f = int.Parse(s.Substring(5, 1));
                    int g = int.Parse(s.Substring(6, 1));
                    int h = int.Parse(s.Substring(7, 1));
                    int k = int.Parse(s.Substring(8, 1));
                    
                    string u = $"{b * 2}{d * 2}{f * 2}{h * 2}";
                    int z = a + c + e + g;
                    int sun = 0;
                    int q = int.Parse(u);
                    while (q != 0)
                    {
                        sun = sun + q % 10;
                        q /= 10;
                    }
                    int total = sun + z;
                    int x = 0;
                    for (int i = 1; i < 11; i++)
                    {
                        if (total % 10 + i == 10)
                        {
                            x = i;
                        }
                    }
                    if (x == k)
                    {
                        Console.WriteLine("This is a valid SIN.");
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid SIN.");
                    }

                }
                else
                {
                    Console.WriteLine("ban phai nhap 9 so");
                }
                if (s == "0")
                {
                    Console.WriteLine("Have a Nice Day!");
                    break;
                }
            }
        }
    }
}