using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ProgramToSwap2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0, firstNumber = 0, secondNumber = 0;
            Console.WriteLine("Insert first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("After swapping first number is: "+firstNumber+" and second number is: "+secondNumber);
            Console.ReadKey();
        }
    }
}
