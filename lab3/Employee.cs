using System;

namespace lab3
{
    public class Employee
    {
       public string FirstName { get; set; } 
       public string LastName { get; set; } 
       public string Address { get; set; } 
       public long Sin { get; set; } 
       public double Salary { get; set; }

       public Employee(string firstName, string lastName, string address, long sin, double salary)
       {
           FirstName = firstName;
           LastName = lastName;
           Address = address;
           Sin = sin;
           Salary = salary;
       }

       public Employee()
       {
       }

       public void ToString()
       {
           Console.WriteLine($"Fullname : {FirstName} {LastName} Address : {Address} Sin : {Sin} Salary : {Salary}");
       }

       public void Calculate(double percentage)
       {
           Console.WriteLine($"the bonus {Salary * percentage}");
       }
    }
}