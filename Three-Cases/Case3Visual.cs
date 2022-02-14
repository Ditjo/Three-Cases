using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_cases_ClassLibrary;
using System.IO;

namespace Three_Cases
{
    public class Case3Visual
    {
        
        public static void IsUser()
        {
            string Brugernavn, password, UserPassFil;
            //starter med at lave et Password object for at kunne tilgå password godkendelsen.
            Case3Logic password_obj = new Case3Logic();

            //Der bliver indlæst fra UserPassword.txt.
            //Hvis den er tom så skal man oprette en ny bruger og password.
            UserPassFil = File.ReadAllText(@"C:\Users\madnie\Documents\Opgaver\C# Cases\Visual Studio Programming\Three-Cases\UserPassword.txt");
            if (string.IsNullOrEmpty(UserPassFil))
            {
                Console.Clear();
                Console.WriteLine("Opret en ny bruger.");
                Console.Write("Brugernavn: ");
                Brugernavn = Console.ReadLine();

                //Passwordet bliver oprettet, hvis det kan godkendes.
                //hvis det ikke kan godkendes skal man indtaste et nyt password.
                do
                {
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                    if(password_obj.Pass(password, Brugernavn) == false)
                    {
                        Console.WriteLine("Ikke godkendt Password");
                    }

                } while (password_obj.Pass(password, Brugernavn) == false);

                //efter godkendelse bliver det indsrkevet i UserPassword.txt
                UserPassFil = Brugernavn + " , " + password;
                File.WriteAllText(@"C:\Users\madnie\Documents\Opgaver\C# Cases\Visual Studio Programming\Three-Cases\UserPassword.txt", UserPassFil);
            }
        }
        public static void Case3()
        {
            string Brugernavn, password, UserPassFil;

            Case3Logic password_obj = new Case3Logic();

            string[] Lines = File.ReadAllLines(@"C:\Users\madnie\Documents\Opgaver\C# Cases\Visual Studio Programming\Three-Cases\UserPassword.txt");

            do
            {
                Console.Write("Nyt Password: ");
                password = Console.ReadLine();

                foreach (string Line in Lines)
                {
                    if (Line.Contains(password))
                    {

                    }
                }

                if (password_obj.Pass(password, Brugernavn) == false)
                {
                    Console.WriteLine("Ikke godkendt Password");
                }

            } while (password_obj.Pass(password, Brugernavn) == false);

        }

    }
}
