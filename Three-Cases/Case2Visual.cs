using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Cases
{
    public class Case2Visual
    {
        public static void Case2()
        {
            //Indtastning af navn på den første danser efterfulgta af point.
            //disse bliver gemt i passende variabler.

            string navn1, navn2, svar, kør = "1";
            int point1, point2;

            while (kør == "1")
            {


                Console.WriteLine();
                Console.Write("Indtast danser 1 navn: ");
                navn1 = Console.ReadLine();
                Console.Write("Indtast danser 1 point: ");
                point1 = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine();
                Console.Write("Indtast danser 2 navn: ");
                navn2 = Console.ReadLine();
                Console.Write("Indtast danser 2 point: ");
                point2 = Convert.ToInt32(Console.ReadLine());

                //Her bliver der kaldt en method hvor der også bliver overført de ovenstående indtastet værdier.
                Three_cases_ClassLibrary.Case2Logic.Dans(navn1, navn2, point1, point2);

                //Her kommer svaret retur og bliver lagt i variablen svar.
                svar = Three_cases_ClassLibrary.Case2Logic.Dans(navn1, navn2, point1, point2);

                //svaret bliver udskrevet.
                Console.WriteLine(svar);

                Console.ReadKey();

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Kør igen?");
                Console.WriteLine();
                Console.WriteLine("1: Kør programmet igen");
                Console.WriteLine("2: Afslut program");
                kør = Console.ReadLine();
            }
        }
    }

}
