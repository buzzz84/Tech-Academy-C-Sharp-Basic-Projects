using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsExercise
{
    class Program
    {
        static void Main()
        {
            //string[] weekDays = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
            //Console.WriteLine("What is your favorite day of the week?");
            //string weekDay = Convert.ToString(Console.ReadLine());
            //bool favDay = false;

            //while (!favDay)
            //{
            //    switch(weekDay.ToLower())
            //    {
            //        case "monday":
            //            Console.WriteLine("Monday Really?!?!? I always get a case of the Mundays.");
            //            favDay = true;
            //            break;
            //        case "tuesday":
            //            Console.WriteLine("Tuesday is really like a junior Monday.");
            //            favDay = true;
            //            break;
            //        case "wednesday":
            //            Console.WriteLine("Wednesday is humpday!");
            //            favDay = true;
            //            break;
            //        case "thursday":
            //            Console.WriteLine("Thursday night football anyone?");
            //            favDay = true;
            //            break;
            //        case "friday":
            //            Console.WriteLine("Friday Night Lights!");
            //            favDay = true;
            //            break;
            //        case "saturday":
            //            Console.WriteLine("Saturday nights alright for fighting.");
            //            favDay = true;
            //            break;
            //        case "sunday":
            //            Console.WriteLine("Sunday is all football for me!");
            //            favDay = true;
            //            break;
            //        default:
            //            Console.WriteLine("Never heard of that day of the week");
            //            Console.WriteLine("Try to guess a real day of the week this time.");
            //            weekDay = Convert.ToString(Console.ReadLine());
            //            break;
            //    }
            //}

            //while (!favDay);

            //Console.Read();


            //int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17 };
            //Console.WriteLine("Can you guess a Prime Number below 18?");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = false;

            //do
            //{
            //    switch(number)
            //    {
            //        case 2:
            //            Console.WriteLine("You guessed 2. That is a Prime Number!!!");
            //            isGuessed = true;
            //            break;
            //        case 3:
            //            Console.WriteLine("You guessed 3. That is a Prime Number!!!");
            //            isGuessed = true;
            //            break;
            //        case 5:
            //            Console.WriteLine("You guessed 5. That is a Prime Number!!!");
            //            isGuessed = true;
            //            break;
            //        case 7:
            //            Console.WriteLine("You guessed 7. That is a Prime Number!!!");
            //            isGuessed = true;
            //            break;
            //        case 11:
            //            Console.WriteLine("You guessed 11. That is a Prime Number!!!");
            //            isGuessed = true;
            //            break;
            //        case 13:
            //            Console.WriteLine("You guessed 13. That is a Prime Number!!!");
            //            isGuessed = true;
            //            break;
            //        case 17:
            //            Console.WriteLine("You guessed 17. That is a Prime Number!!!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You did not guess a prime number.");
            //            Console.WriteLine("Try another guess for Prime Number below 18?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //    }
            //}

            //while (!isGuessed);

            //Console.Read();



            var groceries = new List<string>() { "bread", "milk", "eggs", "cheese", "apples", "bacon" };
            Console.WriteLine("Name an item you might find on a typical grocery list.");
            string grocery = Convert.ToString(Console.ReadLine());
            bool shopping = false;

            do
            {
                switch (grocery.ToLower())
                {
                    case "bread":
                        Console.WriteLine("Nothing like an MLT, mutton lettuce and tomato sandwich.");
                        shopping = true;
                        break;
                    case "milk":
                        Console.WriteLine("It's so hot, milk was a bad choice.");
                        shopping = true;
                        break;
                    case "eggs":
                        Console.WriteLine("what came first...the chicken or the...");
                        shopping = true;
                        break;
                    case "cheese":
                        Console.WriteLine("Do you need a little wine with that cheese?");
                        shopping = true;
                        break;
                    case "apples":
                        Console.WriteLine("How you like dem apples?");
                        shopping = true;
                        break;
                    case "bacon":
                        Console.WriteLine("Bacon is the greatest invention since the wheel.");
                        shopping = true;
                        break;
                    default:
                        Console.WriteLine("Interesting items you shop for");
                        Console.WriteLine("Try to guess a more common grocery list item.");
                        grocery = Convert.ToString(Console.ReadLine());
                        break;
                }
            }

            while (!shopping);

            Console.Read();
        }
    }
}
