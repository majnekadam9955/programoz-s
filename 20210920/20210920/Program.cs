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

        static void Main(string[] args)
        {

            feladat1();

        }
    }
}
