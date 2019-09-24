using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_calc
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Type Enter  number:  ");

            int x;
            if (int.TryParse(Console.ReadLine(), out x))
            {
                Calculator.FindFact(x, 1);
            }
            else
            {
                Console.WriteLine("The value is not a valid integer." +
                    "\n Try whole numbers (e.g 1, 5, 7, 9).");
                Console.ReadKey();
            }
        }
    }
}
