using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_cases_ClassLibrary
{
    public class Case2Logic
    {

        //inkomne information fra Case2Visual
        public static string Dans(string navn1, string navn2, int point1, int point2)
        {
            
                //Her bliver der kaldt på en constructor som opretter en ny danser og indsætter onformationerne.
                DancerPoint Danser1 = new DancerPoint(navn1, point1);
                DancerPoint Danser2 = new DancerPoint(navn2, point2);

                //pointende bliver lagt sammen.
                int point = Danser1.point + Danser2.point;
                //her bliver den afsluttende sætning sat sammen.
                string navn = Danser1.navn + " & " + Danser2.navn + " " + point + " point";
                //her bliver den retuneret. 
                return navn;
            }
        }
        
        //dette er en ny class
        public class DancerPoint
    {
        //Her bliver der lavet 2 nye fields
        public string navn;
        public int point;

        //dette er en constructor.
        //den opretter et nyt objects og i dette tilfælde bliver der indsat navn og point.
        public DancerPoint(string navn, int point)
        {

            this.navn = navn;
            this.point = point;
        }
    }
}


