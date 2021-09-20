using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210920
{
    class Program
    {

        static void feladat1()
        {

            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {

                Console.WriteLine("A szám páros!");

            }
            else
            {

                Console.WriteLine("A szám páratlam!");

            }

        }

        static void feladat2()
        {

            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {

                Console.WriteLine("A szám negatív!");

            }
            else if (a == 0)
            {

                Console.WriteLine("A szám eggyenlő 0-val");

            }
            else
            {

                Console.WriteLine("a szám pozitív!");

            }

        }

        static void feladat3()
        {

            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {

                Console.WriteLine("Odakint fagy van!");

            }
            else if (a == 0)
            {

                Console.WriteLine("Fagypont van");

            }
            else
            {

                Console.WriteLine("Nincs fagy odakint");

            }

        }












        static void Main(string[] args)
        {

            feladat1();

            feladat2();

            feladat3();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("nyomjon enter-t!");
            Console.ReadLine();
        }
    }
}
