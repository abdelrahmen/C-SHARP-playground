using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__playground
{
    public class Employee
    {
        public int EmployeeNumber { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }

        public Employee(int EmployeeNumber, string firstName, string lastName, int age, string address, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Address = address;
            this.EmployeeNumber = EmployeeNumber;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{EmployeeNumber,-10} {FirstName,-15} {LastName,-15} {Salary,15:C}";
        }
    }
}
