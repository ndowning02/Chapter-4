using System;

namespace DoorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;
            

            Console.WriteLine("Pick a door 1, 2, or 3");
            userEntry = Convert.ToInt32(Console.ReadLine());
            if (userEntry == 1)
            {
                Console.WriteLine("500 Dollars");
            }
            else if (userEntry == 2)
             {
                Console.WriteLine("A new Car");
             }
            else if (userEntry == 3)
            {
                Console.WriteLine("A Sandwich");
            }
            else if (userEntry == 4)
            {
                Console.WriteLine("Wrong answer");
            }
        }
    }
}
