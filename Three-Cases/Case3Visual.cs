using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_cases_ClassLibrary;

namespace Three_Cases
{
    public class Case3Visual
    {
        public static void Case3()
        {
            
            Console.Clear();
            Console.Write("Skriv password: ");
            string password = Console.ReadLine();

            Case3Logic password_obj = new Case3Logic();

            var result = password_obj.Lengt(password);

            Console.WriteLine(result);
            Console.ReadKey();

            result = password_obj.Tal(password);

            Console.WriteLine(result);
            Console.ReadKey();

            result = password_obj.Letter(password);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
