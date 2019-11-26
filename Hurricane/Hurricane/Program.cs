using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            int windSpeed;

            Console.WriteLine("Enter the windspeed of the hurricane to see what category it is in.");
            windSpeed = Convert.ToInt32(Console.ReadLine());

            if (windSpeed >= 157)
            {
                Console.WriteLine("Category 5");
            }
            else if (windSpeed < 157 && windSpeed >= 137)
            {
                Console.WriteLine("Category 4");
            }
            else if (windSpeed < 137 && windSpeed >= 111)
            {
                Console.WriteLine("Category 3");
            }
            else if (windSpeed < 111 && windSpeed >= 96)
            {
                Console.WriteLine("Category 2");
            }
            else if (windSpeed < 96 && windSpeed >= 74)
            {
                Console.WriteLine("Category 1");
            }
            else if (windSpeed < 74)
            {
                Console.WriteLine("The storm you entered is not a hurricane");
            }


        }
    }
}
