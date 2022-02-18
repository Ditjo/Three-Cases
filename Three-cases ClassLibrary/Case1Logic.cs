using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_cases_ClassLibrary
{
    public class Case1Logic
    {
        public static string Fodbold(int afl, string mål)
        {
            //Den inkomne information bliver ændret.
            string huh;

            mål = mål.ToLower();

            //Er der mål. Hvis der er, bliver der udskrevet Olé Olé Olé og resten bliver sprunget over.
            if (mål == "mål")
            {
                //afl bliver retuneret med Olé Olé Olé.
                return "Olé Olé Olé";
            }
            else
            {
                //hvis der ikke er mål.
                //Er der 10 eller flere afleveringer.
                if (afl >= 10)
                {
                    return "High Five - Jubel!!!";
                }
                //er der mellem 0 og 10 afleveringer
                else if (afl > 0)
                {
                    huh = "";

                    //Huh sætning bliver lavet her.
                    while (afl > 0)
                    {
                        afl--;
                        huh = huh + " Huh!";
                    }
                    return huh;
                }
                //hvis der ikke er nogle afleveringer så shh.
                else
                {
                    return "Shh";
                }
            }
            
                
        }
    }
}
