using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ProgramToGetaNumberAndDisplayTheSumOfTheDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, temp = 0, sum = 0, r = 0;
            Console.WriteLine("Insert number: ");
            bool parse = int.TryParse(Console.ReadLine(), out number);
            if (parse)
            {
                temp = number;
                while (temp != 0)
                {
                    r = temp % 10;
                    temp /= 10;
                    sum += r;
                }
                Console.WriteLine("Sum of digits of the number " + number + " is " + sum);
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
