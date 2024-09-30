using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guess = -1;
        Console.WriteLine(number);
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower ");
            } 
            else if (guess < number)
            {
                Console.WriteLine("Higher ");
            }
            else 
            {
                Console.WriteLine("You got it!");
            }
        }

    
    }
}