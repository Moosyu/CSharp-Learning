using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soulja_boy
{
    class SouljaClass
    {

        internal static void SouljaBoy()
        {

            double i = 1;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Enter a number of soulja boys!");

            try
            {
                int soulja = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Printing " + soulja + " soulja boys");

                while (i <= soulja)
                {
                    Console.WriteLine("soulja boy");
                    i++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please input a number!");
            }

            Console.ReadKey();

        }

    }
}
