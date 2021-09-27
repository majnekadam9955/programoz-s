using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210927
{
    class Program
    {

        static void feladat1()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat1");
            Console.WriteLine();
            Console.WriteLine("Kérek egy számot!");


            int szam = Convert.ToInt32(Console.ReadLine());

            switch (szam)
            {

                case 1:
                    Console.WriteLine("Január");
                    break;

                case 2:
                    Console.WriteLine("Február");
                    break;

                case 3:
                    Console.WriteLine("Március");
                    break;

                case 4:
                    Console.WriteLine("Április");
                    break;

                case 5:
                    Console.WriteLine("Május");
                    break;

                case 6:
                    Console.WriteLine("Június");
                    break;

                case 7:
                    Console.WriteLine("Július");
                    break;

                case 8:
                    Console.WriteLine("Augusztus");
                    break;

                case 9:
                    Console.WriteLine("Szeptember");
                    break;

                case 10:
                    Console.WriteLine("Október");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;


                default:
                    Console.WriteLine("túl nagy számot adtál meg");
                    break;
            }

        }

        static void feladat2()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat2");
            Console.WriteLine();
            Console.WriteLine("Kérek egy számot!");


            int honap = Convert.ToInt32(Console.ReadLine());

            switch (honap)
            {

                case 1:
                    Console.WriteLine("Tél");
                    break;
                case 2:
                    Console.WriteLine("Tél");
                    break;
                case 3:
                    Console.WriteLine("tavasz");
                    break;
                case 4:
                    Console.WriteLine("tavasz");
                    break;
                case 5:
                    Console.WriteLine("tavasz");
                    break;
                case 6:
                    Console.WriteLine("nyár");
                    break;
                case 7:
                    Console.WriteLine("nyár");
                    break;
                case 8:
                    Console.WriteLine("nyár");
                    break;
                case 9:
                    Console.WriteLine("Ősz");
                    break;
                case 10:
                    Console.WriteLine("Ősz");
                    break;
                case 11:
                    Console.WriteLine("Ősz");
                    break;
                case 12:
                    Console.WriteLine("Tél");
                    break;





                default:
                    Console.WriteLine("nincs ilyen szám!");
                    break;
            }

        }

        static void feladat3()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("feladat3");
            Console.WriteLine();
            Console.WriteLine("Kérek egy számot!");

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
            Console.WriteLine("Nyomjon enter-t");
            Console.ReadLine();
        }
    }
}
