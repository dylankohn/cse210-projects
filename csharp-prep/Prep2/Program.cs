using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePerc = int.Parse(userInput);

        if (gradePerc >= 90)
        {
            Console.WriteLine("You have an A!");
        }
        else if (gradePerc >= 80)
        {
            Console.WriteLine("You have a B!");
        }
        else if (gradePerc >= 70)
        {
            Console.WriteLine("You have a C!");
        }
        else if (gradePerc >= 60)
        {
            Console.WriteLine("You have a D");
        }
        else if (gradePerc < 60)
        {
            Console.WriteLine("You are failing you have an F");
        }


    }
}