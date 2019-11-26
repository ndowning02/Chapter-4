using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int userEntry;
            int rndNumber = rnd.Next(1, 10);
            Console.WriteLine("Please enter a number between 1 and 10");
            userEntry = Convert.ToInt32(Console.ReadLine());
            string choice;

            if (userEntry == rndNumber)
            {
                Console.WriteLine("How did you know it was {0}?", userEntry);
                Console.WriteLine("Would you like to go double or nothing?");
                choice = Console.ReadLine();
                if (choice.Equals("Yes"))
                {
                    Console.WriteLine("Congratulations you are a degenerate gambler.");
                }
                else
                {
                    Console.WriteLine("Way to quit when you are ahead");
                }

            }
            else
            { Console.WriteLine("{0} that was incorrect. ", userEntry);
            }
        }
    }
}
