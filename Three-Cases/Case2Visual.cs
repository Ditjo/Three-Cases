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

                string navn1, navn2, kør = "1";
                int point1, point2;

                while (kør == "1")
                {

                    Console.Clear();
                    //navn og point danser1
                    Console.WriteLine();
                    Console.Write("Indtast danser 1 navn: ");
                    navn1 = Console.ReadLine();
                    Console.Write("Indtast danser 1 point: ");
                    point1 = Convert.ToInt32(Console.ReadLine());

                    //Navn og point danser2
                    Console.WriteLine();
                    Console.Write("Indtast danser 2 navn: ");
                    navn2 = Console.ReadLine();
                    Console.Write("Indtast danser 2 point: ");
                    point2 = Convert.ToInt32(Console.ReadLine());
                    
                    //informationen bliver lagt i vær deres objekt
                    Dancepoint danser1 = new Dancepoint(navn1, point1);
                    Dancepoint danser2 = new Dancepoint(navn2, point2);

                    //ved at lægge danser1 og danser2 sammen bruger den den overloaded operator + i logiken
                    Dancepoint resultat = danser1 + danser2;
                    
                    //resultatet bliver udskrevet her ved at kalde på de navn og point.
                    Console.WriteLine(resultat.Navn + resultat.Point);
                    
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


