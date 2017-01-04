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
            int number2 = 0;
            
            while (number2 < 1 || number2 > 101)
            {
                Random rnd = new Random();
                Random r = new Random();
                int add = 0;
                int sous = 0;
                int mult = 0;
                int div = 0;

                for (int ctr = 1; ctr <= 3; ctr++)
                {
                    
                    int number = rnd.Next(1, 12);
                    Console.WriteLine("random");
                    Console.WriteLine(number);
                    if (ctr <= 1)
                    {
                        number2 = number;
                        Console.WriteLine("premier nombre");
                        Console.WriteLine(number2);
                    }
                    if (ctr > 1)
                    {
                        bool verif = false;
                        while (verif == false)
                        {
                            int num = r.Next(1, 5);
                            if (num == 1 && add == 0)
                            {
                                number2 = number2 + number;
                                Console.WriteLine("addition");
                                Console.WriteLine(number2);
                                add = 1;
                                verif = true;
                            }
                            else if (num == 2 && sous == 0)
                            {
                                number2 = number2 - number;
                                Console.WriteLine("soustraction");
                                Console.WriteLine(number2);
                                sous = 1;
                                verif = true;
                            }
                            else if (num == 3 && mult == 0)
                            {
                                number2 = number2 * number;
                                Console.WriteLine("multiplication");
                                Console.WriteLine(number2);
                                mult = 1;
                                verif = true;
                            }
                            else if (num == 4 && div == 0)
                            {
                                number2 = number2 / number;
                                Console.WriteLine("division");
                                Console.WriteLine(number2);
                                div = 1;
                                verif = true;
                            }
                        }
                    }
                }
                for (int ctr = 2; ctr <= 3; ctr++)
                {
                    while (add == 0 || sous == 0 || mult == 0 || div == 0)
                    {
                    int number = rnd.Next(1, 20);
                    Console.WriteLine("random");
                    Console.WriteLine(number);
                    if (ctr <= 1)
                    {
                        number2 = number;
                        Console.WriteLine("affiche");
                        Console.WriteLine(number2);
                    }
                        if (ctr > 1)
                        {
                            bool verif = false;
                            while (verif == false)
                            {
                                int num = r.Next(1, 5);
                                if (num == 1 && add == 0)
                                {
                                    number2 = number2 + number;
                                    Console.WriteLine("addition");
                                    Console.WriteLine(number2);
                                    add = 1;
                                    verif = true;
                                }
                                else if (num == 2 && sous == 0)
                                {
                                    number2 = number2 - number;
                                    Console.WriteLine("soustraction");
                                    Console.WriteLine(number2);
                                    sous = 1;
                                    verif = true;
                                }
                                else if (num == 3 && mult == 0)
                                {
                                    number2 = number2 * number;
                                    Console.WriteLine("multiplication");
                                    Console.WriteLine(number2);
                                    mult = 1;
                                    verif = true;
                                }
                                else if (num == 4 && div == 0)
                                {
                                    number2 = number2 / number;
                                    Console.WriteLine("division");
                                    Console.WriteLine(number2);
                                    div = 1;
                                    verif = true;
                                }
                            }
                        }
                }
                }
                Console.WriteLine("--------------------FINALUS--------------------");
                Console.WriteLine(number2);
            }
            Console.ReadLine();
        }
    }
}
