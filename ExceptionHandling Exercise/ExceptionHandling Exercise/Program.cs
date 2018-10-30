using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userInput = false;
            while (!userInput)

                try
                {
                    Console.WriteLine("How old are you?");
                    int userAge = Convert.ToInt32(Console.ReadLine());

                    if (userAge == 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if (userAge < 0)
                    {
                        throw new ArgumentNullException();
                    }

                    DateTime birthYear = DateTime.Now;
                    Console.WriteLine("Your birth year is: " + (birthYear.Year - userAge));
                    Console.ReadLine();
                    return;
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("You cannot be age zero!!!");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Fantastic attempt Mr Benjamin Button, but try entering a positive age.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something stinks in Suburbia");
                }

            Console.ReadLine();


        }
    }
}
