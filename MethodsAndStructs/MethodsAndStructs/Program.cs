using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    class Program
    {
        static void Main()
        {
            var reverser = new Reverser();
            var upperReverser = new UpperCaseReverser();

            var word = "Ejaz is the best baby!";
            //Console.WriteLine($"upper reverser transform: {wordTransform.Transform(word)}");
            Console.WriteLine($"upper reverser transform: {reverser.Transform(word)}");
            Console.WriteLine($"upper reverser transform: {upperReverser.Transform(word)}");

            //var calc = new Calculator();
            //calc.Add(10,20);

            //var numbers = new int[] { 1, 2, 3 };
            //calc.Add(numbers);

            //var savings = new InterestAccount();
            //savings.accountType = "savings";
            //savings.isActive = true;
            //savings.amount = 9000.7M;
            //Console.WriteLine(savings.amount);

            //var rex = new TRex();
            //rex.Name = "Luchasaurus";
            //rex.Roar();
            
            //var bigBoat = new Boat();
            //bigBoat.Name = "Titanic";
            //bigBoat.Tonnage = 46_000;

            //Boat? mysteriousBoat = bigBoat;
            //Boat mysteriousBoatValue = mysteriousBoat.Value; 
            //mysteriousBoatValue.Name = "Mary Celeste";
            //mysteriousBoatValue.Tonnage = 247;

            //Console.WriteLine($"{bigBoat.Name} - {bigBoat.Tonnage} tons");
            //Console.WriteLine($"{mysteriousBoatValue.Name} - {mysteriousBoatValue.Tonnage} tons");

            //mysteriousBoat = null;

            //Console.WriteLine($"{bigBoat.Name} - {bigBoat.Tonnage} tons");
            //Console.WriteLine($"{mysteriousBoatValue.Name} - {mysteriousBoatValue.Tonnage} tons");

            //var clicker = new NPC("Clicker");
            //Console.WriteLine($"This new enemy named {clicker.Name} is dangerous, luckily it's only currently at {clicker.Health}");

            //var toyo = new Car();
            //Console.WriteLine($"The speed is {toyo.Speed}");
            //toyo.Speed = 45.09;
            //Console.WriteLine($"The speed is {toyo.Speed}");


            //var monster = new Monster();
            //monster.Name = "Cookie Monster";
            //monster.Damage = 10;

            //Console.WriteLine($"{monster.Name} does {monster.Damage} damage");
            //monster.DoubleDamage = true;
            //Console.WriteLine($"{monster.Name} does {monster.Damage} damage");


            //var service = new WebService();
            //var data = service.GetStudentProfile(100);

            //Console.WriteLine(data.student.firstName + " " + data.Item1.lastName);
            //Console.WriteLine(data.grades[0]);
            //var UXforVR = new BookReview();

            //UXforVR.SetName("UXforVR");
            //UXforVR.SetScore(7);

            //Console.WriteLine(UXforVR.GetName());
            //Console.WriteLine(UXforVR.GetScore());
        }
    } 
}
