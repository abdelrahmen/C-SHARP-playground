using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__playground
{
    internal class Repository
    {
        private static List<Employee> employees = new List<Employee> {
        new Employee(1, "John", "Doe", 30, "123 Main St.", 50000),
            new Employee(2, "Jane", "Smith", 25, "456 Elm St.", 45000),
            new Employee(3, "Bob", "Johnson", 40, "789 Oak St.", 60000),
            new Employee(4, "Alice", "Williams", 35, "321 Pine St.", 55000),
            new Employee(5, "David", "Brown", 28, "654 Maple St.", 48000),
            new Employee(6, "Karen", "Jones", 45, "987 Cedar St.", 70000),
            new Employee(7, "Tom", "Davis", 32, "246 Birch St.", 52000),
            new Employee(8, "Linda", "Garcia", 27, "135 Spruce St.", 47000),
            new Employee(9, "Mike", "Martinez", 38, "864 Walnut St.", 65000),
            new Employee(10, "Sara", "Wilson", 31, "579 Cherry St.", 53000),
            new Employee(11, "Chris", "Taylor", 29, "802 Laurel St.", 49000),
            new Employee(12, "Laura", "Brown", 33, "948 Cypress St.", 57000),
            new Employee(13, "Mark", "Gonzalez", 36, "731 Cedar St.", 62000),
            new Employee(14, "Amy", "Rodriguez", 26, "572 Oak St.", 46000),
            new Employee(15, "Kevin", "Hernandez", 42, "319 Main St.", 68000),
            new Employee(16, "Emily", "Lopez", 24, "246 Pine St.", 44000),
            new Employee(17, "Jason", "Jones", 39, "865 Elm St.", 59000),
            new Employee(18, "Stephanie", "Garcia", 27, "732 Oak St.", 48000),
            new Employee(19, "Joshua", "Martinez", 34, "579 Cedar St.", 55000),
            new Employee(20, "Amanda", "Wilson", 31, "802 Birch St.", 51000),
            new Employee(21, "Richard", "Taylor", 29, "948 Cherry St.", 47000),
            new Employee(22, "Jessica", "Brown", 33, "731 Cypress St.", 53000),
            new Employee(23, "Daniel", "Gonzalez", 36, "572 Walnut St.", 59000),
            new Employee(24, "Jennifer", "Rodriguez", 26, "319 Main St.", 45000),
            new Employee(25, "Timothy", "Hernandez", 42, "246 Pine St.", 66000),
            new Employee(26, "Brittany", "Lopez", 24, "865 Elm St.", 43000),
            new Employee(27, "Adam", "Jones", 39, "732 Oak St.", 57000),
            new Employee(28, "Megan", "Garcia", 27, "579 Cedar St.", 49000),
            new Employee(29, "Christopher", "Martinez", 34, "802 Birch St.", 54000),
            new Employee(30, "Lauren", "Wilson", 31, "948 Cherry St.", 50000),
            new Employee(31, "Brandon", "Taylor", 29, "731 Cypress St.", 46000),
            new Employee(32, "Rachel", "Brown", 33, "572 Walnut St.", 52000),
            new Employee(33, "Jonathan", "Gonzalez", 36, "319 Main St.", 61000),
            new Employee(34, "Katie", "Rodriguez", 26, "246 Pine St.", 47000),
            new Employee(35, "Tyler", "Hernandez", 42, "865 Elm St.", 70000),
            new Employee(36, "Courtney", "Lopez", 24, "732 Oak St.", 42000),
            new Employee(37, "Ryan", "Jones", 39, "579 Cedar St.", 56000),
            new Employee(38, "Taylor", "Garcia", 27, "802 Birch St.", 50000),
            new Employee(39, "David", "Martinez", 34, "948 Cherry St.", 52000),
            new Employee(40, "Melissa", "Wilson", 31, "731 Cypress St.", 48000),
            new Employee(41, "Steven", "Taylor", 29, "572 Walnut St.", 54000),
            new Employee(42, "Christina", "Gonzalez", 36, "319 Main St.", 59000),
            new Employee(43, "Nicholas", "Rodriguez", 26, "246 Pine St.", 45000),
            new Employee(44, "Jordan", "Hernandez", 42, "865 Elm St.", 68000),
            new Employee(45, "Kayla", "Lopez", 24, "732 Oak St.", 41000),
            new Employee(46, "Andrew", "Jones", 39, "579 Cedar St.", 55000),
            new Employee(47, "Alexis", "Garcia", 27, "802 Birch St.", 49000),
            new Employee(48, "Benjamin", "Martinez", 34, "948 Cherry St.", 56000),
            new Employee(49, "Haley", "Wilson", 31, "731 Cypress St.", 52000),
            new Employee(50, "Jacob", "Taylor", 29, "572 Walnut St.", 48000),
        };

        public static List<Employee> GetAllEmployees()
        {
            return employees;
        }

    }
}
