using System;

namespace lab7
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary   { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}  Age: {Age}  Salary: {Salary}$";
        }
    }
}