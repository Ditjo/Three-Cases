using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_cases_ClassLibrary;

namespace Three_Cases
{
    public class Case1Visual
    {
        public static void Fodbold()
        {
            string mål, resultat, kør = "1";
            int afl;

            do
            {
                //Overskrift og hvor mange afleveringer.
                Console.Clear();
                Console.WriteLine("Fodbold Logik");
                Console.Write("Hvor mange afleveringer er der lavet: ");
                //det bliver lagt i en string
                afl = Convert.ToInt32(Console.ReadLine());

                //Er der mål. Hvis der er mål skriv mål.
                Console.Write("Har der været mål(Indtast mål hvis ja)");
                mål = Console.ReadLine();

                //Methoden Fodbold bliver brugt her og og hvad der skal siges ender i resultat.
                resultat = Case1Logic.Fodbold(afl, mål);

                //resultatet bliver udskrevet. 
                Console.WriteLine(resultat);

                //afventer på et tryk før programmet afslutter.
                Console.ReadKey();

                //Kør igen?
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Kør igen?");
                Console.WriteLine();
                Console.WriteLine("1: Kør programmet igen");
                Console.WriteLine("2: Afslut program");
                kør = Console.ReadLine();
            } while (kør != "2");
        }
    }
}
