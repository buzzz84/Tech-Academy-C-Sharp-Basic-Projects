using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 54321 };
            Employee employee2 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 12345 };
            employee1.SayName();
            employee2.SayName();
            Console.WriteLine(employee1.Id == employee2.Id);
            Console.WriteLine(employee1.Id != employee2.Id);
            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
