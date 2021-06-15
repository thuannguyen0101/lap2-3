using System;
using System.Text;

namespace lab4
{
    public class Staff : Employee
    {
        public string Title { get; set; }

        public void HienThiStaff()
        {
            Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}, Title: {Title}");
        }
        
        public void StaffNhan()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"{0.06 * Salary}$");
        } 
    }
}