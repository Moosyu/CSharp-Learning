using System;
using System.Timers;

public class Sus
{
    //Thank god for google, would have never figured this out
    private static System.Timers.Timer aTimer;

    static void Main()
    {
        SetTimer();

        Console.WriteLine("\nPress the Enter key to continue the application...\n");

        //hh is hours, mm is minutes and ss is seconds
        Console.WriteLine("The application started at {0:HH:mm:ss}", DateTime.Now);
        
        Console.ReadLine();

        static void SetTimer()
        {
            aTimer = new System.Timers.Timer(2000);
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        Random rnd = new Random();


        string[] names = {
            "joe", "chris", "rx", "rby", "friend", "sus", "test"
        };


        int index = rnd.Next(names.Length);

        int num = rnd.Next();

        //Just a random number
        Console.WriteLine(num);

        //Legit the most hamfisted solution I have ever used also I have no idea why I to pad right 6 times for one space please explain 
        Console.WriteLine("Hello".PadRight(6) + names[index]);

        aTimer.Stop();

        Console.WriteLine("The application ended at {0:HH:mm:ss}", DateTime.Now);

    }

}