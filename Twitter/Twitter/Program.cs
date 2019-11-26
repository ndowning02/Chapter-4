using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            string result;
            Console.WriteLine("Enter your message (Message must be 140 characters or less.)");
            message = Console.ReadLine();

            if (message.Length > 140)
            {
                Console.WriteLine(" Message is too long please shorten to 140 charcters or less");
            }
            else if (message.Length <= 140)
            {
                Console.WriteLine("Accepted");
            }

        }
    }
}
