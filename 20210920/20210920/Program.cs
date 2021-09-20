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

        static void feladat4()
        {

            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 40 && a > -30)
            {

                Console.WriteLine("a szám -30 és 40 között van!");

            }
            else
            {

                Console.WriteLine("A szám kívül esik a -30 és 40-es inter vallumon!");

            }

        }

        static void feladat5()
        {

            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 16)
            {

                a = a * 10;
                Console.WriteLine(a);

            }
            else if (a >= 16)
            {

                a = a / 3;
                Console.WriteLine(a);

            }
            

        }

        static void feladat6()
        {

            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 10 && a < 20)
            {

                Console.WriteLine("tizesek");

            }
            else if (a > 20 && a <30)
            {

                Console.WriteLine("huszasok");

            }
            else if (a > 30 && a < 40)
            {

                Console.WriteLine("harmincasok");

            }
            else if (a > 40 && a < 50)
            {

                Console.WriteLine("negyvenesek");

            }
            else if (a < 10 && a > 50)
            {

                Console.WriteLine("a szám nem tartozik bele a 10-50-es intervallumba");

            }
           

        }

        static void feladat7()
        {

            Console.WriteLine("kérek egy számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 12 && a < 25 && a % 2 == 0)
            {

                Console.WriteLine(a);

            }
            else
            {

                Console.WriteLine("A szám nem osztható 2-vel vagy nincs benne a 12-25-ös intervallumban");

            }

        }





        static void Main(string[] args)
        {

            feladat1();

            feladat2();

            feladat3();

            feladat4();

            feladat5();

            feladat6();

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
