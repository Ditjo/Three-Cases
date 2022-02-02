using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_cases_ClassLibrary
{
    public class Case1Logic
    {
        public static string Fodbold(string afl, string mål)
        {
            //mål bliver lavet til lower. Derved er det ligemeget om det bliver indskrevet med stort eller småt.
            mål = mål.ToLower();
            //afl bliver konverteret fra en string til en int. 
            int intafl = Convert.ToInt32(afl);

            //Er der mål. Hvis der er, bliver der udskrevet Olé Olé Olé og resten bliver sprunget over.
            if (mål == "mål")
            {
                //afl bliver retuneret med Olé Olé Olé.
                return afl = "Olé Olé Olé";
            }
            else
            {
                //hvis ikke ovenstående kører else
                //hvis intafl er større end eller ligmed 10 så er det High Five - Jubel!!!
                if (intafl >= 10)
                {
                    return afl = "High Five - Jubel!!!";
                }
                //Ellers hvis den er større end 0 så bliver der udskrevet Huh i den givende mængde
                else if (intafl > 0)
                {
                    //afl bliver tømt
                    afl = "";

                    //den går ind i en while loop hvor den køre indtil intafl er mindre end 0. 
                    while (intafl > 0)
                    {
                        //hver omgang bliver der trukket 1 fra
                        intafl--;
                        //og der bliver lagt en ekstra Huh til.
                        afl = afl + " Huh!";
                    }
                    //efterfølgende retunere den
                    return afl;
                }
                //hvis ikke nogen af de ovenstående retunere den med Shh
                else
                {
                    return afl = "Shh";
                }
            }
            
                
        }
    }
}
