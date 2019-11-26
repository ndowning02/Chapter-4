using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 11);
            int userEntry;

            Console.WriteLine("Pick a number between 1 and 11");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == randomNumber)
            {
                Console.WriteLine("You are correct");
            }
            else if (userEntry > randomNumber)
            {
                Console.WriteLine("Too high");
            }
            else if (userEntry < randomNumber)
            {
                Console.WriteLine("Too Low");
            }
        }
    }
}
