using System;

namespace lab4
{
    public abstract class Employee : Person
    {
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }

        public void HienThiEmployee()
        {
            Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}, Salary: {Salary}, HireDele: {HireDate}");
        }
    }
}