using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Company_Roster
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> departmentStorage = new List<string>();
            List<decimal> salaryStorage = new List<decimal>();
            List<Employee> employeeCollection = new List<Employee>();
            var numberOfEmplyees = Console.ReadLine();

            for (int i = 0; i < int.Parse(numberOfEmplyees); i++)
            {
                var employeeInformation = Console.ReadLine().Split().ToList();
                var name = employeeInformation[0];
                var salary = decimal.Parse(employeeInformation[1]);
                var department = employeeInformation[2];

                employeeCollection.Add(new Employee(name, salary, department));
            }

            
            foreach(var currentDepartment in employeeCollection.Select(x => x.Department).Distinct())
            {
                var currentDepartmentAverageSalary = employeeCollection.Where(x => x.Department == currentDepartment).Select(x => x.Salary).Average();
                departmentStorage.Add(currentDepartment);
                salaryStorage.Add(currentDepartmentAverageSalary);
            }

            Console.WriteLine("Highest Average Salary: {0}", departmentStorage[salaryStorage.IndexOf(salaryStorage.Max())]);

            foreach (Employee emps in employeeCollection.Where(d => d.Department == departmentStorage[salaryStorage.IndexOf(salaryStorage.Max())]).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine("{0} {1:F2}", emps.Name, emps.Salary);
            }
        }
    }
}
