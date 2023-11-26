using System;

class Program
{
    static void Main()
    {
        // Create a Random object
        Random random = new Random();

        // Generate a random number between 1 and 100
        int randomNumber = random.Next(1, 101);

        Console.WriteLine("Random Number: " + randomNumber);
    }
}
