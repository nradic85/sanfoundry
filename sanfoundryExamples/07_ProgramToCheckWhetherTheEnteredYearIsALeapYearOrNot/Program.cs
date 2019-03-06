using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ProgramToCheckWhetherTheEnteredYearIsALeapYearOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter a year: ");
            bool parse = int.TryParse(Console.ReadLine(), out year);
            if (parse)
            {
                if ((year % 4 == 0 && year%100!=0) || (year%400==0))
                {
                    Console.WriteLine("Godina "+year+" je prijestupna!!!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Godina {0} nije prijestupna!!!", year);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Unesi bodinu u brojčanoj vrijednosti!!!!");
                Console.ReadKey();
            }
        }
    }
}
