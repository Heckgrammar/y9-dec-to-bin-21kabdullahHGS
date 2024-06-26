using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MAIN:  NUMBER CONVERSION PROGRAM

            Console.WriteLine( "Please enter your number:" );
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the numberbase you want converting to:");
            int userNumBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberConversion(userNum, userNumBase)); ;
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            string result = "";
            int x = 0;
            do
            {
                x = x * 10;
                x = (number % numberbase) + x;
                number = number / numberbase;
                result = x.ToString();
            } while (number != 0 & numberbase != 0);

                return result; //REMOVE THE RED LINE!sS
        }
    }
}
