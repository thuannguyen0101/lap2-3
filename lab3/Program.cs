using System;

namespace lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Atom atom = new Atom();
            while (true)
            {
                var a = atom.Accept();
                if (atom.Number == 0)
                    
                {
                    if (a)
                    {
                        atom.Display();
                    }
                    break;
                }
            }
           
        }
    }
}