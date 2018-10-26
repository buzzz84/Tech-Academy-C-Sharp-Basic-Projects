using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercise2
{
    class MathNumbers
    {
        public int MathInput(int number)
        {
            int newNumber = number * 4;
            return newNumber;
        }
        public int MathInput(decimal number)
        {
            int newNumber = Convert.ToInt32(number * 11);
            return newNumber;
        }
        public int MathInput(string number)
        {
            try
            {
                int newNumber = Convert.ToInt32(number) + 9;
                return newNumber;
            }
            catch (FormatException)
            {
                return 9;
            }
        }
    }
}
