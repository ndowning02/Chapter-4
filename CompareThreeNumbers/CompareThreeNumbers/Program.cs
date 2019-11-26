using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Enter an integer >>>");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                if (num1 == num3)
                {
                    Console.WriteLine("All three numbers are equal.");
                }
                else
                {
                    Console.WriteLine("Hey buddy only num1 and num2 are equal.");
                }
             }            
             else if (num1 == num3)
            {
                Console.WriteLine("First and last are equal.");
            }
            else if (num2 == num3)
            {
                Console.WriteLine("Last two numbers are equal.");
            }
            else
            {
                Console.WriteLine("No two numbers are equal.");
            }

        }
    }
}
