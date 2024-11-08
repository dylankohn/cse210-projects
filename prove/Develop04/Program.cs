using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            string menuinput = Console.ReadLine();
            int userinput = int.Parse(menuinput);

            switch (userinput)
            {
                case 1:
                    new Breathing();
                    break;
                case 2:
                    new Reflection();
                    break;
                case 3:
                    new Listing();
                    break;
                case 4:
                    Console.WriteLine("Quitting program");
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid option");
                    continue;
            }

        }
    }
}
