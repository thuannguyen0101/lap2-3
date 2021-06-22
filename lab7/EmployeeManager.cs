using System;
using System.Collections.Generic;

namespace lab7
{
    public class EmployeeManager
    {
        private Dictionary<string, Employee> _employees = new Dictionary<string, Employee>();

        public void Add()
        {
            Console.WriteLine("Please enter ID");
            var id = Console.ReadLine();
            Console.WriteLine("Please enter Name");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter Age");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Salary");
            var salary = double.Parse(Console.ReadLine());
            _employees.Add(id,new Employee()
            {
                Name = name,
                Age = age,
                Salary = salary
            });
            Console.WriteLine("Successfully added employees");
        }

        public void Update()
        {
            Console.WriteLine("Please enter ID");
            var id = Console.ReadLine();
            if (_employees.ContainsKey(id))
            {
                Console.WriteLine("Pleaser new Name");
                var name = Console.ReadLine();
                Console.WriteLine("Please new Age");
                var age = int.Parse(Console.ReadLine());
                Console.WriteLine("Please new Salary");
                var salary = double.Parse(Console.ReadLine());
                _employees[id].Name = name;
                _employees[id].Age = age;
                _employees[id].Salary = salary;
                Console.WriteLine("Successfully update employees");
            }
            else
            {
                Console.WriteLine("Employees does not exist");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Please enter ID");
            var id = Console.ReadLine();
            if (_employees.ContainsKey(id))
            {
                _employees.Remove(id);
                Console.WriteLine("Successfully delete employees");
            }
            else
            {
                Console.WriteLine("Employees does not exist");
            }
        }

        public void Display()
        {
            if (_employees.Count == 0)
            {
                Console.WriteLine("There are no employees in the system");
                return;
            }
            else
            {
                Console.WriteLine("----- List Employees -----");
                foreach (var employee in _employees)
                {
                    Console.WriteLine($"ID: {employee.Key} {employee.Value}");
                }
            }
        }
    }
}