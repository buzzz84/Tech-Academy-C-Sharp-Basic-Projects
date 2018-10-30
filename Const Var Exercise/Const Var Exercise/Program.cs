using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const string favSong = "Welcome to the Machine.";

            Console.WriteLine("Tell me your favorite song title.");
            var yourFavSong = Console.ReadLine();

            Console.WriteLine("Your favorite song is " + yourFavSong + " and my favorite song is " + favSong);
            Console.ReadLine();
        }
    }
}
