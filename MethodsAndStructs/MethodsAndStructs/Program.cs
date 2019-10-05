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
            var toyo = new Car();
            Console.WriteLine($"The speed is {toyo.Speed}");
            toyo.Speed = 45.09;
            Console.WriteLine($"The speed is {toyo.Speed}");


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
