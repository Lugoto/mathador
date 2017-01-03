using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathador
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Random rnd = new Random();

            Console.WriteLine("\n20 random integers from 0 to 100:");
            for (int ctr = 1; ctr <= 3; ctr++)
            {
                Console.Write("{0,6}", rnd.Next(1, 12));
                if (ctr % 5 == 0) Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
