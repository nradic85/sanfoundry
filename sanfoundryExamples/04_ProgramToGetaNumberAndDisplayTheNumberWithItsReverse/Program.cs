using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ProgramToGetaNumberAndDisplayTheNumberWithItsReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, tempNum, reverse = 0;
            Console.WriteLine("Enter a number: ");
            bool parse = int.TryParse(Console.ReadLine(), out number);
            if (parse)
            {
                tempNum = number;
                while (number != 0)
                {
                    reverse *= 10;
                    reverse += number % 10;
                    number /= 10;
                }
                Console.WriteLine("Reverse of " + tempNum + " is " + reverse);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Insert number");
                Console.ReadKey();
            }
        }
    }
}
