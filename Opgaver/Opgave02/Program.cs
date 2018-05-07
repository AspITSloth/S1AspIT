using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave02
{
    class Program
    {
        static void Main(string[] args)
        {

            //2.1.1
            string firstName = "Karsten";
            string lastName = "Hansen";
            int age = 35;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);

            Console.WriteLine($"Fornavn: {firstName} Efternavn: {lastName} Alder: {age}");

            //2.2.1
            string titel = "Lord of The Rings - The Two Towers";
            long isbn = 9780007117116;
            int pages = 450;
            double price = 249.95;

            Console.WriteLine(titel);
            Console.WriteLine(isbn);
            Console.WriteLine(pages);
            Console.WriteLine(price);


            //2.3.1
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);

            Console.ReadKey();
        }
    }
}
