using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave01
{
    class Program
    {
        static void Main(string[] args)
        {
            string motto;
            string schoolName;
            motto = "Fokuseret Talent";
            schoolName = "AspIT";

            Console.WriteLine(schoolName);

            schoolName = "AspIT - Storkøbenhavn";

            Console.WriteLine(schoolName + " " + motto);

            Console.WriteLine($"{schoolName}, er en skole i Høje Taastrup. Mottoet for skolen er {motto}.");

            Console.ReadKey();
        }
    }
}
