using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise2
{
    public class Info
    {
        //public static int Numbers (int num1, int num2)
        //{
        //    int results = num1 * Convert.ToInt32(num2);
        //    return results;
        //}
        public static int Numbers (int num1, int num2 = 15)
        {
            int results = num1 * Convert.ToInt32(num2);
            return results;
        }
    }
}

