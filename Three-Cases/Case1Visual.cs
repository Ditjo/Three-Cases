using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Cases
{
    public class Case1Visual
    {
        public static void Case1()
        {
            //Overskrift og hvor mange afleveringer.
            Console.WriteLine("Fodbold Logik");
            Console.Write("Hvor mange afleveringer er der lavet: ");
            //det bliver lagt i en string
            string afl = Console.ReadLine();

            //Er der mål. Hvis der er mål skriv mål.
            Console.Write("Har der været mål(Indtast mål hvis ja)");
            string mål = Console.ReadLine();

            ///De 2 strings bliver sendt til understående fil. 
            ///Her ligger logikken. Det er her at man finder ud af hvad der skal siges.
            Three_cases_ClassLibrary.Case1Logic.Fodbold(afl, mål);

            //her bliver kommer resultatet retur og det bliver lagt i en string
            string resultat = (Three_cases_ClassLibrary.Case1Logic.Fodbold(afl, mål));

            //resultatet bliver udskrevet. 
            Console.WriteLine(resultat);

            //afventer på et tryk før programmet afslutter.
            Console.ReadKey();
        }
    }
}
