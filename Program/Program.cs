﻿using System;
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

        int num = rnd.Next();

        //Just a random number
        Console.WriteLine($"\nA random number is{num}");

        //im suffering from some sort of disability 
        Console.WriteLine("\nHello " + names[index]);

        Console.WriteLine($"\nYour dice rolled {roll}");

        Console.WriteLine("\nToday is {0:d} at {0:T}.", date1);
    }

}
