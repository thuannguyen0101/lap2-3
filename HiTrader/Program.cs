using System;

namespace HiTrader
{
    internal class Program 
    {
        public static void Main(string[] args)
        {
            HuobiTrader huobiTrader = new HuobiTrader();
            BitfinexTrader bitfinexTrader = new BitfinexTrader();
            Console.WriteLine("Which platform do you want to get information from?\n");
            Console.WriteLine("choice \n1 -Houbi \n2- Bitfinex");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    var listHs = huobiTrader.GetTickers();
                    foreach (var list in listHs)
                    {
                        Console.WriteLine(list.ToString());
                    }
                    break;
                case 2:
                    var listBs = bitfinexTrader.GetTickers();
                    foreach (var listB in listBs)
                    {
                        Console.WriteLine(listB.ToString());
                    }
                    break;
                    
            }
        }
    }
}