using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addmission
{
    class Program
    {
        static void Main(string[] args)
        {
            double GPA;
            double testScore;

            Console.WriteLine("Please enter your GPA.");
            GPA = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter your test score.");
            testScore = Convert.ToDouble(Console.ReadLine());

            if (GPA >= 3 && testScore >= 60)
            {
                Console.WriteLine("Accepted");
            }
            else if (GPA < 3 && testScore >= 80)
            {
                Console.WriteLine("Accepted");
            }
            else if (GPA < 3 && testScore < 80)
            {
                Console.WriteLine("Rejected.");
            }
            else if (GPA >= 3 && testScore <60)
            {
                Console.WriteLine("Rejected.");
            }
        }
    }
}
