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
            //vælg hvilket program man vil starte.
            Console.WriteLine();
            Console.WriteLine("Vælg program du vil køre:");
            Console.WriteLine("1: Fodbold program");
            Console.WriteLine("2: Danse program");
            //valget bliver lagt i en string.
            string program = Console.ReadLine();

            if (program == "1")
            {
                Case1Visual.Case1();
            }
            else if(program == "2")
            {
                //Case2Visual
            }
            else
            {

            }
            

        }
    }
}
