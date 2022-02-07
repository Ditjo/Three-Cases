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

            while (program == "1" || program == "2")
                //vælg hvilket program man vil starte.
                Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Vælg program du vil køre:");
            Console.WriteLine("1: Fodbold program");
            Console.WriteLine("2: Danse program");
            //valget bliver lagt i en string.
            program = Console.ReadLine();

            if (program == "1")
            {
                Case1Visual.Case1();
            }
            else if(program == "2")
            {
                Case2Visual.Case2();
            }
            else
            {

            }
            

        }
    }
}
