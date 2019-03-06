using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ProgramToDisplayTheDateInVariousFormats
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# Program to Display the Date in Various Formats 
             */

            DateTime date = DateTime.Now;
            
            //DateTime date = new DateTime(2019, 3, 6);
            Console.WriteLine("Some date formats: ");
            Console.WriteLine("Date and time: {0}", date);
            Console.WriteLine(date.ToString("yyyy-MM-dd"));
            Console.WriteLine(date.ToString("dd-MMM-yyy"));
            Console.WriteLine(date.ToString("M/d/yyyy"));
            Console.WriteLine(date.ToString("M/d/yy"));
            Console.WriteLine(date.ToString("MM/dd/yyyy"));
            Console.WriteLine(date.ToString("MM/dd/yy"));
            Console.WriteLine(date.ToString("yy/MM/dd"));
            Console.Read();
        }
    }
}
