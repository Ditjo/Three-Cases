using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_cases_ClassLibrary
{
    public class Case3Logic
    {
        public string Lengt(string password)
        //er passwordet 12 karaktere eller længere.
        {
            if (password.Length >= 12)
            {
                return "Godkendt";
            }
            else
                return "Error to short passeword length!";
        }

        public string Letter(string password)
        //Både store og små bogstaver.
        {
            if (password.Equals(password.ToUpper()) || password.Equals(password.ToLower()))
            {
                return "Godkendt Bogstaver";
            }
            else
            {
                return "mangler upper eller lower case";
            }
        }

        /*public bool Tegn(string password)
            //Benyt min et special tegn
        {
            return password;
        }*/

        public string Tal(string password)
        //ingen tal i starten eller slutningen af passwordet 
        {
            bool tal = char.IsDigit(password[0]) || char.IsDigit(password[password.Length-1]);
            if (tal == false)
            {
                return "Godkendt tal";
            }
            else
                return "Tal i start eller slut";
        }

        public bool Mellemrum(string password)
        //ingen mellemrum
        {
            if (password.Contains(" "))
            {
                return false;
            }
            else
                return true;
        }

        /*public string Brugernavn(string password)
            //burgernavn og password må ikke være det samme.
        {
            return password;
        }*/
    }
}
