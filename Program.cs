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


            int userNum = -1;
            int userNumBase = -1;
            while (userNum <= -1)
            {
                Console.WriteLine("Please enter your number  (0 to 2147483647):");

                userNum = Convert.ToInt32(Console.ReadLine());
            }
            while (userNumBase <= -1 || userNumBase > 36)
            {

                Console.WriteLine("Please enter the numberbase you want converting to (2 to 36):");

                userNumBase = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(numberConversion(userNum, userNumBase)); ;

        }



        //static void means the function will not return a value so it does not need a data type  

        //...this function DOES return a value so the method must have a data types 

        static string numberConversion(int number, int numberbase)

        {

            string result = "";

            do

            {

                string x = Convert.ToString(number % numberbase);

                if (x == "10")
                {

                    x = "A";

                }

                else if (x == "11")

                {

                    x = "B";

                }

                else if (x == "12")

                {

                    x = "C";

                }

                else if (x == "13")

                {

                    x = "D";

                }

                else if (x == "14")

                {

                    x = "E";

                }

                else if (x == "15")

                {

                    x = "F";

                }

                else if (x == "16")

                {

                    x = "G";

                }

                else if (x == "17")

                {

                    x = "H";

                }

                else if (x == "18")

                {

                    x = "I";

                }

                else if (x == "19")

                {

                    x = "J";

                }

                else if (x == "20")

                {

                    x = "K";

                }

                else if (x == "21")

                {

                    x = "L";

                }

                else if (x == "22")

                {

                    x = "M";

                }

                else if (x == "23")

                {

                    x = "N";

                }

                else if (x == "24")

                {

                    x = "O";

                }

                else if (x == "25")

                {

                    x = "P";

                }

                else if (x == "26")

                {

                    x = "Q";

                }

                else if (x == "27")

                {

                    x = "R";

                }

                else if (x == "28")

                {

                    x = "S";

                }

                else if (x == "29")

                {

                    x = "T";

                }

                else if (x == "30")

                {

                    x = "U";

                }

                else if (x == "31")

                {

                    x = "V";

                }

                else if (x == "32")

                {

                    x = "W";

                }

                else if (x == "33")

                {

                    x = "X";

                }

                else if (x == "34")

                {

                    x = "Y";

                }

                else if (x == "35")

                {

                    x = "Z";

                }

                result = x + Convert.ToString(result);

                number = number / numberbase;

            } while (number != 0 & numberbase != 0);



            return result;
        }
    }
}