using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int price;
            Console.WriteLine("Enter the price for the item you are trying to purchase");
            price = Convert.ToInt32(Console.ReadLine());

            if (price > 5000)
            {
                Console.WriteLine("Sorry the amount is over your credit limit");
            }
            else if (price <= 5000)
            {
                Console.WriteLine("Approved");
            }
        }
    }
}
