using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Opgave03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.1
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            //3.2
            Console.ForegroundColor = ConsoleColor.Green;

            //3.3
            Console.WindowHeight = 30;
            Console.WindowWidth = 30;


            //3.4
            Console.Beep(4000, 1000);

            Console.ReadKey();
        }
    }
}
