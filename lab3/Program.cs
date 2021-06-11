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

            Employee employee = new Employee();
            Console.WriteLine("please enter first name");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("please enter last name");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("please enter address");
            employee.Address = Console.ReadLine();
            Console.WriteLine("please enter sin");
            employee.Sin = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter salary");
            employee.Salary = double.Parse(Console.ReadLine());
            employee.ToString();
            double c = double.Parse(Console.ReadLine());
            employee.Calculate(c);
        }
    }
}