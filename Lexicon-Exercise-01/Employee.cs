using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_01
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string salary;

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

        public string GetFirstName()
        {
            return firstName;
        }
    }
}
