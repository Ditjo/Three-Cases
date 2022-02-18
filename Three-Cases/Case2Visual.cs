using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_cases_ClassLibrary;

namespace Three_Cases
{
    public class Case2Visual
    {
        public static void Dans()
        {
            //Indtastning af navn på den første danser efterfulgta af point.
            //disse bliver gemt i passende variabler.

            string navn1, navn2, svar, kør = "1";
            int point1, point2;

            while (kør == "1")
            {
                Case2Logic Danser_obj = new Case2Logic();

                //Danser 1: Navn og point.
                Console.WriteLine();
                Console.Write("Indtast danser 1 navn: ");
                navn1 = Console.ReadLine();
                Console.Write("Indtast danser 1 point: ");
                point1 = Convert.ToInt32(Console.ReadLine());

                //Danser 2: Navn og point
                Console.WriteLine();
                Console.Write("Indtast danser 2 navn: ");
                navn2 = Console.ReadLine();
                Console.Write("Indtast danser 2 point: ");
                point2 = Convert.ToInt32(Console.ReadLine());

                //Mothoden er overloaded. Den har samme navn men gør noget forskelliget alt efter hvilket indput den for.
                svar = Danser_obj.Dans(navn1, navn2);
                svar = svar + Danser_obj.Dans(point1, point2);

                //svaret bliver udskrevet.
                Console.WriteLine(svar);

                Console.ReadKey();

                //kør igen?
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
