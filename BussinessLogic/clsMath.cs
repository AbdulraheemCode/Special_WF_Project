using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class clsMath
    {

        public static double Add(double x , double y)
        {
            return x + y;
        }

        public static void PrintString(string str)
        {
            Console.WriteLine($"Your String : {str}"); 
        }

        public static void ConactStrings(string str1 , string str2)
        {
            Console.WriteLine($"{str1} {str2}");
        }


    }
}
