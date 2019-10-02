using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerBottles
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = null;
            var text = name + " Johnson";
            Console.WriteLine(text);
            string lastName = null;
            int? it = null;
            float? fl = null;
            it += 1;

            Console.WriteLine($"number = {it}");

            string anotherName = null;
            Console.WriteLine(anotherName.ToUpper());

            //print out bottles of beer song in program
            //store beer amount in variables
            //subtract after each iteration

            //var beerBottles = 5;

            //var song = beerBottles + " bottles of beer on the wall, " + beerBottles + " bottles of beer. Take one down and pass it around, " + (beerBottles - 1) + " bottles of beer on the wall.";

            //Console.WriteLine(song);

            //beerBottles = beerBottles - 1;

            //song = beerBottles + " bottles of beer on the wall, " + beerBottles + " bottles of beer. Take one down and pass it around, " + (beerBottles - 1) + " bottles of beer on the wall.";

            //Console.WriteLine(song);
        }
    }
}
