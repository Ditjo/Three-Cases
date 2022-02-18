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
            //denen metode ser om der er skrevet noget i UserPassword i forvejen.
            //gør der ikke det bliver man bedt om at lave en ny.
            string Brugernavn, password, Isempty;

            //starter med at lave et Password object for at kunne tilgå password godkendelsen.
            Case3Logic password_obj = new Case3Logic();

            //Der bliver indlæst fra UserPassword.txt.
            //Hvis den er tom så skal man oprette en ny bruger og password.
            Isempty = File.ReadAllText(@"C:\Users\madnie\Documents\Opgaver\C# Cases\Visual Studio Programming\Three-Cases\UserPassword.txt");
            if (string.IsNullOrWhiteSpace(Isempty))
            {
                Console.Clear();
                Console.WriteLine("Opret en ny bruger.");
                Console.Write("Brugernavn: ");
                Brugernavn = Console.ReadLine();

                //Passwordet bliver oprettet, hvis det kan godkendes.
                //hvis det ikke kan godkendes skal man indtaste et nyt password.
                do
                {
                    Console.WriteLine("Password skal være:");
                    Console.WriteLine("~ Min 12 karaktere lang");
                    Console.WriteLine("~ Store og må bogstaver");
                    Console.WriteLine("~ Specialtegn");
                    Console.WriteLine("~ Ingen tal i start og slut");
                    Console.WriteLine("~ Ingen mellemrum");
                    Console.WriteLine("~ Må ikke være brugernavn");
                    Console.Write("Password: ");
                    
                    password = Console.ReadLine();
                    if (password_obj.Pass(password, Brugernavn) == false)
                    {
                        Console.WriteLine("Ikke godkendt Password");
                    }

                } while (password_obj.Pass(password, Brugernavn) == false);

                //efter godkendelse bliver det indskrevet i UserPassword.txt
                string[] UserPassFil= {Brugernavn, password};
                File.WriteAllLines(@"C:\Users\madnie\Documents\Opgaver\C# Cases\Visual Studio Programming\Three-Cases\UserPassword.txt", UserPassFil);
            }
        }

        public static void Login()
        {
            //Man skal logge ind før man kan få adgang til programmerne. 
            //denne metode udfører dette job.
            string brugernavn, inputbruger,password, inputpassword;

            //brugernavn og password bliver hentet ind i et array.
            string[] Lines = File.ReadAllLines(@"C:\Users\madnie\Documents\Opgaver\C# Cases\Visual Studio Programming\Three-Cases\UserPassword.txt");

            //de bliver lagt i vær deres string
            brugernavn = Lines[0];
            password = Lines[1];

            //man indtaster Brugernavn og password.
            //passer det ikke bliver man bedt om at gøre det igen.
            do
            {
                Console.Clear();
                Console.Write("Brugernavn: ");
                inputbruger = Console.ReadLine();

                Console.Write("Password: ");
                inputpassword = Console.ReadLine();

                if(brugernavn != inputbruger || password != inputpassword)
                {
                    Console.WriteLine("Forkert brugernavn eller password");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Velkommen");
                    Console.ReadKey();
                }
            } while (brugernavn != inputbruger || password != inputpassword);
            

        }
        public static void NewPassword()
        {
            //Hvis man vil ændre password kan det ske her. 
            Console.Clear();
            string Brugernavn, password, oldpassword;

            Case3Logic password_obj = new Case3Logic();

            //Brugernavn og password bliver hentet ind og lagt i vær deres string
            string[] Lines = File.ReadAllLines(@"C:\Users\madnie\Documents\Opgaver\C# Cases\Visual Studio Programming\Three-Cases\UserPassword.txt");

                Brugernavn = Lines[0];
                oldpassword = Lines[1];

                //Man indtaster det nye password og kan det ikke godkendes bliver man bedt om at skrive et nyt.
                do
                {
                    Console.WriteLine("Password skal være:");
                    Console.WriteLine("~ Min 12 karaktere lang");
                    Console.WriteLine("~ Store og må bogstaver");
                    Console.WriteLine("~ Specialtegn");
                    Console.WriteLine("~ Ingen tal i start og slut");
                    Console.WriteLine("~ Ingen mellemrum");
                    Console.WriteLine("~ Må ikke være brugernavn");
                    Console.WriteLine("~ Må ikke være gammelt password");
                    Console.Write("Nyt Password: ");
                    password = Console.ReadLine();

                    if (password_obj.Pass(password, Brugernavn) == false || password == oldpassword)
                    {
                        Console.WriteLine("Ikke godkendt password");
                    }
                } while (password_obj.Pass(password, Brugernavn) == false || password == oldpassword);

            //er det nye password godkendt bliver det lagt i arrayet sammen med det samme brugernavn og bliver skrevet ind i UserPassword.txt
            string[] UserPassFil = { Brugernavn, password };
            File.WriteAllLines(@"C:\Users\madnie\Documents\Opgaver\C# Cases\Visual Studio Programming\Three-Cases\UserPassword.txt", UserPassFil);

            Console.WriteLine("Password er blevet ændret");
            Console.ReadKey();
        }

    }
}
