using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Sus
{

    static void Main()
    {


        Random rnd = new Random();

        DateTime date1 = DateTime.Now;

        int roll = rnd.Next(1, 6);

        string[] names = {
            "Joe", "Chris", "George", "Phil", "Friend", "Sus", "Boy", "Walt"
        };


        int index = rnd.Next(names.Length);

        //im suffering from some sort of disability 
        Console.WriteLine("\nHello " + names[index]);

        Console.WriteLine($"\nYour dice rolled {roll}");

        Console.WriteLine("\nToday is {0:d} at {0:T}.", date1);

        try
        {

            Console.WriteLine("\nEnter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour number was: " + $" {number}");
        }

        catch (Exception)
        {
            Console.WriteLine("Please input a number!");
        }
        Console.WriteLine("\nPress any button to close the program!");
        Console.ReadLine();
    }

}
