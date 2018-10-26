using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>
            { FirstName = "Sample", LastName = "Student", Id = 54321, things = new List<string> { "bacon", "eggs", "sausage" } };
            Employee<int> employee2 = new Employee<int> { FirstName = "Sample", LastName = "Student", Id = 12345, things = new List<int> { 1, 8, 7 } };
            foreach (int things in employee2.things)
            {
                Console.WriteLine(things);
            }
            foreach (string things in employee1.things)
            {
                Console.WriteLine(things);
            }
            employee1.SayName();
            employee2.SayName();
            Console.WriteLine(employee1.Id == employee2.Id);
            Console.WriteLine(employee1.Id != employee2.Id);
            //IQuittable quittable = new Employee();
            //quittable.Quit();
            Console.ReadLine();
        }
    }
}
