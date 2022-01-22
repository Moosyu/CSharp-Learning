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


        string[] names = {
            "joe", "chris", "george", "phil", "friend", "sus", "test"
        };


        int index = rnd.Next(names.Length);

        int num = rnd.Next();

        //Just a random number
        Console.WriteLine(num);

        //Legit the most hamfisted solution I have ever used also I have no idea why I to pad right 6 times for one space please explain 
        Console.WriteLine("Hello".PadRight(6) + names[index]);

        //Easiest thing I've ever done
        int roll = rnd.Next(1, 6);
        Console.WriteLine($"Your dice rolled {roll}");


        Console.WriteLine("The application ended at {0:HH:mm:ss}", DateTime.Now);

    }

}
