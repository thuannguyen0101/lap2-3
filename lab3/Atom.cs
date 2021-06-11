using System;
using System.Collections.Generic;

namespace lab3
{
    public class Atom
    {
        public int Number { get; set; }
        public string Symbol { get; set; }
        public string Fullname { get; set; }
        public string Weight { get; set; }

        public static List<Atom> List = new List<Atom>();

        public Boolean Accept()
        {
            while (true)
            {
                Console.WriteLine("Enter atomic number");
                Number = int.Parse(Console.ReadLine());
                if (Number == 0)
                {
                    Display();
                    Console.WriteLine("No Sym Name Weight");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter symbol :");
                    Symbol = Console.ReadLine();
                    Console.WriteLine("Enter full name :");
                    Fullname = Console.ReadLine();
                    Console.WriteLine("Enter atomic weight :");
                    Weight = Console.ReadLine();    
                
                    if (List.Count > 10)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        List.Add(new Atom()
                        {
                            Number = Number,
                            Symbol = Symbol,
                            Fullname = Fullname,
                            Weight = Weight,
                        });
                        return true;
                    }    
                }
            }
            return false;
        }
        public void Display()
        {
            foreach (var atom in List)
            {
                Console.WriteLine($"{atom.Number} {atom.Symbol} {atom.Fullname} {atom.Weight}");
            }
           
        }
    }
}