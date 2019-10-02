using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAtWork
{
    class Program
    {

        enum EngineType
        {
            gasolone, electric, hybrid, hydrogen
        }
        static void Main(string[] args)
        {

            var names = new string[] { "Ejaz", "Akbar", "Merchant" };
            foreach (string name in names)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine("");
            var iterator = 0;
            while (iterator < names.Length)
            {
                Console.Write($"{names[iterator]} ");
                iterator += 1;
            }
            Console.WriteLine("");
            iterator = 0;

            do
            {
                Console.Write($"{names[iterator]} ");
                iterator += 1;
            } while (iterator < names.Length);


            //var numbers = new int[] { 0, 1, 2, 3 };
            //foreach (var num in numbers)
            //{
            //    Console.Write("hi");
            //}


            //Control Flow
            //enums
            //if statements
            //compound nested if statements
            //ternary
            //switch statements
            //arrays
            //for loops
            //while and do while loops
        }
    }
}
