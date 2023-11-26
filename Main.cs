using System;

class Program
{
    static void Main()
    {
        String choice;
        Boolean exit = false;
        while (!exit)
        {
            Console.WriteLine("Play(Y?N)");
            Console.WriteLine("-------------------");
            choice = Console.ReadLine().ToLower();
            Console.WriteLine("-------------------");
            switch (choice)
            {
                case "y":

                    Console.WriteLine("---- RamDom game ----");
                    Console.WriteLine("Input from 1 to 10:");
                    int rd = numberRandom();
                    int number = Input();
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Number random: {0}, Numer you choice: {1}", rd, number);
                    Console.WriteLine("-------------------");
                    if (rd == number)
                    {
                        Console.WriteLine("U win!");
                        Console.WriteLine("-------------------");
                    }
                    else
                    {
                        Console.WriteLine("U lose 5k!");
                        Console.WriteLine("-------------------");
                    }
                    break;

                case "n":

                    Console.WriteLine("Bye :)))");
                    exit = true;
                    break;

                default:

                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine("-------------------");

                    break;
            }
        }
    }
    //=================================================
    static int numberRandom()
    {
        Random ramdom = new Random();
        return ramdom.Next(1, 10);

    }

    //==================================================
    private static int Input()
    {
        int number;

        while (true)
        {
            try
            {
                String src = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(src))
                {
                    Console.WriteLine("Not empty, OK?");
                    Console.WriteLine("-------------------");
                    continue;
                }

                number = int.Parse(src);

                if (number < 1 || number > 10)
                {
                    Console.WriteLine("Number from 1 to 10, OK?");
                    Console.WriteLine("-------------------");
                }
                else
                {
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input number, OK?");
                Console.WriteLine("-------------------");
            }
        }
        return number;
    }
}
