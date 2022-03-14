using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Cases
{
    public class ProgramVisual
    {
        static void Main(string[] args)
        {
            string program = "0";
            //IsUser bruges til at se om der faktisk er oprettet en bruger.
            //Hvis der ikke er det så bliver man bedt om at gøre det.
            Case3Visual.IsUser();

            //Man bliver bedt om at logge ind.
            Case3Visual.Login();

                do
                {
                    //vælg hvilket program man vil starte.
                    Console.Clear();
                    Console.WriteLine("Menu");
                    Console.WriteLine("1: Fodbold program");
                    Console.WriteLine("2: Danse program");
                    Console.WriteLine("3: Ændre Login");
                    Console.WriteLine("0: Lukker programmet");
                    //valget bliver lagt i en string.
                    program = Console.ReadLine();

                    if (program == "1")
                    {
                        Case1Visual.Fodbold();
                    }
                    else if (program == "2")
                    {
                        Case2Visual.Dans();
                    }
                    else if (program == "3")
                    {
                        Case3Visual.NewPassword();
                    }
                    else if (program == "0")
                    {
                        Console.WriteLine("Lukker program");
                        Console.ReadKey();
                    }
                } while (program != "0");

        }
    }
}
