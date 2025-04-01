using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_01
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string salary;

        public Employee(string firstName, string lastName, string salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public void showEmployeeInfo()
        {
            Console.WriteLine($"Name: {firstName} {lastName}, Salary: {salary}");
        }
    }
}
