using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToCheckWhetherTheEnteredNumberIsEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Insert number:");
            i=int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered number is an Even Number");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Entered number is an Odd Number");
                Console.ReadKey();
            }
        }
    }
}
