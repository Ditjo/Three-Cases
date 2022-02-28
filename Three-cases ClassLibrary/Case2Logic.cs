using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_cases_ClassLibrary
{
    public class Dancepoint
    {
        //der bliver lavet 2 fields: Navn og Point
        public string Navn;
        public int Point;

        public Dancepoint(string navn, int point)
        //fieldsne bliver sat i forbindelse med strings
        {
            Navn = navn;
            Point = point;
        }
        public static Dancepoint operator +(Dancepoint danser1, Dancepoint danser2)
        //operator + bliver overloaded. Når man lægger danser1 og danser2 sammen så gør den det som sker nedenunder.
        {
            //Navn bliver lagt sammen til en string ved brug af "string interpolation operator($)"
            string resultatNavn = $"{danser1.Navn} & {danser2.Navn} ";

            //Point bliver lagt sammen som man ved matematik
            int resultatPoint = danser1.Point + danser2.Point;

            //det nye objekt bliver fyldt med informationen ovenfra
            Dancepoint resultat = new Dancepoint(resultatNavn, resultatPoint);

            //og returneret
            return resultat;

        }
    }
}


