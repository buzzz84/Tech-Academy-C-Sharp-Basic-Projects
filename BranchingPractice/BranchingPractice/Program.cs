using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";

            Console.WriteLine(result);
            Console.ReadLine();
            
            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhh....something went wrong.");
            //}
            //Console.ReadLine();


            //int currentTemperature = 68;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //Console.ReadLine();







            //if (true)
            //{
            //    Console.WriteLine(“Hello!”);
            //}

            //if (1 == 1)
            //{
            //    Console.WriteLine(“1 equals 1!”);
            //}
            //else
            //{
            //    Console.WriteLine(“1 does not equal 1”);
            //}

            //string name = “Brett”

            //if (name == “Jesse”)
            //{
            //    Console.WriteLine(“Your name is Jesse”);
            //}
            //else
            //{
            //    Console.WriteLine(“Your name is not Jesse”);
            //}

            //string name = “Adam”

            //if (name == “Jesse”)
            //{
            //    Console.WriteLine(“Your name is Jesse”);
            //}
            //else if (name == “Brett”)
            //{
            //    Console.WriteLine(“Your name is Brett”);
            //}
            //else //Dont need an else statement to finish statements
            //{
            //    Console.WriteLine(“Your name is not Jesse. Your name is not Brett.”);
            //}

            ////If one of these expressions inside parenthesis evaluates to true, then rest are skipped.
            //string name = “Erik”;

            //if (name == “Jesse”)
            
            //    Console.WriteLine(“Your name is Jesse”);
            //}
            //else if (name == “Brett”)
            //{
            //    Console.WriteLine(“Your name is Brett”);
            //}
            //else if (name == “Adam”)
            //{
            //    Console.WriteLine(“Your name is Adam”);
            //}

            ////If one of these expressions inside parenthesis evaluates to true, then rest are still run because missing ELSE.
            //string name = “Adam”;

            //if (name == “Jesse”)
            //{
	           // Console.WriteLine(“Your name is Jesse”);
            //}
            //if (name == “Brett”)
            //{
	           // Console.WriteLine(“Your name is Brett”);
            //}
            //if (name == “Adam”)
            //{
	           // Console.WriteLine(“Your name is Adam”);
            //}
            
            //// The != operator answers the question “Does the value on my left NOT equal the value on my right?”.
            //string name = “Brett”;

            //if (name != “Jesse”)
            //{
	           // Console.WriteLine(“Your name is not Jesse”);
            //}

            //if (1 != 2)
            //{
	           // Console.WriteLine(“All is right with the universe.”);
            //}
            //else
            //{
	           // Console.WriteLine(“We live in bizarro world.”);
            //}

            //// Greater Than example
            //if (2 > 1)
            //{
	           // Console.WriteLine(“Two is greater than one.”)
            //}
            //else
            //{
	           // Console.WriteLine(“Something is severely wrong if this prints to the console.”);
            //}

            //// Lesser Than Example
            //int age = 19;

            //if (age< 21)
            //{
	           // Console.WriteLine(“No you may not purchase that bottle of wine.”)
            //}
            //else
            //{
	           // Console.WriteLine(“That will be $23.71”);
            //}

            //// Lesser Than Or Equals Example
            //int age = 20;

            //if (age <= 20)
            //{
	           // Console.WriteLine(“You may not purchase that bottle of wine.”)
            //}
            //else
            //{
	           // Console.WriteLine(“There you go.”)
            //}
            ////The (age <= 20) asks the question, “Is the value on the left less than or equal to the value on the right?”
            
            
            ////Greater Than Or Equals Example
            //if (age >= 25)
            //{
	           // Console.WriteLine(“Yes you may rent a car from us.”);
            //}
            //else
            //{
	           // Console.WriteLine(“No you may not rent a car from us.”);
            //}
            
            //// Multiple Operator Example for IF statement
            //if (1 == 1 && 5 ==5)
            //{
	           // Console.WriteLine(“All is right with the world.”);
            //}

            //// OR
            //if (true && true && true)
            //{
	           // Console.WriteLine(“Everything is true.”);
            //}

            //// For the statement inside the parentheses to evaluate to true using the AND operator, each expression on the left and right of it must be true.
            //if (true && true && true && true && false)
            //{
	           // Console.WriteLine(“All is true!”)
            //}
            //else
            //{
	           // Console.WriteLine(“There was a false somewhere!”);
            //}

            //// Real Life Example
            //int packageWeight = 50;
            //int packageLength = 25;

            //if (packageWeight > 40 && packageLength > 20)
            //{
	           // Console.WriteLine(“This package is too big to ship.”);
            //}
            
            //// Using OR operator
            //if (true || false)
            //{
	           // Console.WriteLine(“At least one value is true.”);
            //}

            //if (false || false)
            //{
	           // Console.WriteLine(“At least one value is true.”);
            //}
            //else
            //{
	           // Console.WriteLine(“No value is true.”);
            //}

            //if (false || false || false || false || true)
            //{
	           // Console.WriteLine(“Something is true.”);
            //}

            //// Real Life Example
            //string role = “admin”;

            //if (role == “admin” || role == “administrator”)
            //{
	           // Console.WriteLine(“You may have access to the entire software system.”);
            //}

            //// How complicated you can get at granular level
            //if (true && ((true || false) || true) && ((false && false) || (true && true)))
            //{
	           // Console.WriteLine(“Wow that was confusing.”);
            //}



        }
    }
}
