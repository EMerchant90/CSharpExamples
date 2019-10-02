using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string dude = "lebowski";
            var dudee = "lebowski";

            //calculations
            var laptops = 300;
            var cars = 500;
            int cellphones = 700;

            var total = laptops + cars + cellphones;

            var average = total / 3;

            Console.WriteLine(average);

            //types
            string name = "Ejaz";
            int age = 29;
            bool isDope = true;

            uint whoa = 9000000;

            //operations
            var firstN = "Scott";
            var lastN = "Mescudi";
            var fullN = firstN + lastN;
            Console.WriteLine(fullN);

            //nulls
            string nullstring = null;

        
        }
    }
}
