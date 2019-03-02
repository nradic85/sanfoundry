using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ProgramToPrintaBinaryTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRows, lastInt = 0;
            Console.WriteLine("Enter the Number of Rows: ");
            bool parse = int.TryParse(Console.ReadLine(), out numberRows);
            if (parse)
            {
                for (int i = 1; i <= numberRows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (lastInt == 1)
                        {
                            Console.Write("0");
                            lastInt = 0;
                        }
                        else if (lastInt == 0)
                        {
                            Console.Write("1");
                            lastInt = 1;
                        }
                    }
                    Console.Write("\n");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Insert number value");
                Console.ReadKey();
            }
        }
    }
}
