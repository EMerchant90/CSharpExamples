using System;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            string[] name = { "Shamilah", "is", "Future", "Mrs.", "Merchant" };
            //Console.WriteLine(name[2]);

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{name[i]} ");
            }
        }
    }
}
