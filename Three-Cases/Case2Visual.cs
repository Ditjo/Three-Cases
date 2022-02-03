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
            Console.WriteLine();
            Console.Write("Indtast danser 1 navn: ");
            string navn1 = Console.ReadLine();
            Console.Write("Indtast danser 1 point: ");
            int point1 = Convert.ToInt32(Console.ReadLine());

            //Indtastning af navn på den anden danser efterfulgta af point.
            //disse bliver gemt i passende variabler.
            Console.WriteLine();
            Console.Write("Indtast danser 2 navn: ");
            string navn2 = Console.ReadLine();
            Console.Write("Indtast danser 2 point: ");
            int point2 = Convert.ToInt32(Console.ReadLine());

            //Her bliver der kaldt en method hvor der også bliver overført de ovenstående indtastet værdier.
            Three_cases_ClassLibrary.Case2Logic.Dans(navn1, navn2, point1, point2);

            //Her kommer svaret retur og bliver lagt i variablen svar.
            string svar = Three_cases_ClassLibrary.Case2Logic.Dans(navn1, navn2, point1, point2);

            //svaret bliver udskrevet.
            Console.WriteLine(svar);

            Console.ReadKey();
        }
    }

}
