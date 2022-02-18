using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Three_cases_ClassLibrary
{
    public class Case3Logic
    {
        public bool Pass(string password, string Brugernavn)
        //Check for at se om alle kriterier opfyldt.
        {
            Case3Logic password_obj = new Case3Logic();

            if (password_obj.Length(password) && password_obj.Letter(password) && password_obj.Tegn(password) && password_obj.Tal(password) && password_obj.Mellemrum(password) && password_obj.Brugernavn(password, Brugernavn) == true)
            {
                return true; //hvis alle ovenstående kriterier er true så retunere den true som derved siger at alle kriterer er opfyldt
            }
                return false;//ellers for man en false, dvs en af kriterierne er ikke opfyldt.
        }
        public bool Length(string password)
        //er passwordet 12 karaktere eller længere.
        {
            if (password.Length >= 12)
            {
                return true; //"Godkendt længde";
            }
            else
                return false; //"Ikke godkendt!";
        }

        public bool Letter(string password)
        //Både store og små bogstaver.
        {
            if (password.Equals(password.ToUpper()) || password.Equals(password.ToLower()))
            {
                return false; // "mangler upper eller lower case";
            }
            else
            {
                return true; // "Godkendt Bogstaver";
            }
        }

        public bool Tegn(string password)
            //Benyt min et special tegn
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetterOrDigit(password[i]) == false)
                {
                    return true; // "Godkendt special tegn";
                }
            }
            return false; // "mangler special tegn";
        }

        public bool Tal(string password)
        //ingen tal i starten eller slutningen af passwordet 
        {
            if (char.IsDigit(password[0]) || char.IsDigit(password[password.Length - 1]) == false)
            {
                return true; // "Godkendt tal";
            }
            else
                return false; // "Tal i start eller slut";
        }

        public bool Mellemrum(string password)
        //ingen mellemrum
        {
            if (password.Contains(" "))
            {
                return false; // "der er mellemrum. Ikke tilladt";
            }
            else
                return true; // "Godkendt mellemrum";
        }

        public bool Brugernavn(string password, string Brugernavn)
            //brugernavn og password må ikke være det samme.
        {
            if (Brugernavn.ToLower() != password.ToLower())
            {
                return true; //De er ikke det samme. Godkendt.
            }
                return false; // De er det samme. Ikke godkendt.
        }
        
    }
}


