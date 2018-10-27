using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee() {FirstName = "Joe", LastName = "Johnson", Id = 12345},
                new Employee() {FirstName = "Joe", LastName = "Jackson", Id = 23456},
                new Employee() {FirstName = "Russell", LastName = "Wilson", Id = 34567},
                new Employee() {FirstName = "Walter", LastName = "Jones", Id = 45678},
                new Employee() {FirstName = "Doug", LastName = "Baldwin", Id = 56789},
                new Employee() {FirstName = "Earl", LastName = "Thomas", Id = 67890},
                new Employee() {FirstName = "Shaun", LastName = "Alexander", Id = 78901},
                new Employee() {FirstName = "Steve", LastName = "Largent", Id = 89012},
                new Employee() {FirstName = "Richard", LastName = "Sherman", Id = 90123},
                new Employee() {FirstName = "Marshawn", LastName = "Lynch", Id = 01234},
                new Employee() {FirstName = "Cortez", LastName = "Kennedy", Id = 11760},
                new Employee() {FirstName = "Kenny", LastName = "Easley", Id = 12457}

            };
            List<Employee> fnameList = new List<Employee>();

            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    fnameList.Add(employee);
                    Console.WriteLine(employee.FirstName);
                }
            }


            List<Employee> Joe = employeeList.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in Joe)
            {
                Console.WriteLine(employee.FirstName);
            }
            List<Employee> Five = employeeList.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in Five)
            {
                Console.WriteLine(employee.Id);
            }

            Console.ReadLine();
            //Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 54321 };
            //Employee employee2 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 12345 };
            //employee1.SayName();
            //employee2.SayName();
            //Console.WriteLine(employee1.Id == employee2.Id);
            //Console.WriteLine(employee1.Id != employee2.Id);
            //IQuittable quittable = new Employee();
            //quittable.Quit();
            //Console.ReadLine();
        }
    }
}
