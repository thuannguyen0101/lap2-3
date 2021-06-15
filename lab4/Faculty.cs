using System;
using System.Text;

namespace lab4
{
    public class Faculty : Employee
    {
        public DateTime OfficeHour{ get; set; }
        public string Rank { get; set; }

        public void HienThiFaculty()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}, Office hour: {OfficeHour}, Rank: {Rank}");
        }
        public void FacultyNhan()
        { 
            Console.OutputEncoding = Encoding.UTF8; 
            Console.WriteLine($"Tiền thưởng: {1000 + 0.05 * Salary}$");
        } 
    }
}