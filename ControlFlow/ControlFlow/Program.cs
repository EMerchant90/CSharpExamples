using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        //enumerations
        enum EngineType
        {
            gasoline, electrical, hybrid
        };

        static void Main(string[] args)
        {
            EngineType engine = EngineType.electrical;
            var message = (engine == EngineType.gasoline) ? "You are driving on gas" : "Not gas";
            Console.WriteLine(message);

            //string[] wrestlingPromotions = new string[3] { "NXT", "AEW", "WWE" };

            //array
            //int[] scores = new int[3];
            //scores[0] = 89;
            //scores[1] = 78;
            //scores[0] = 91;

            //var highScores = new int[]
            //{
            //    130, 555, 666
            //};

            //var moreHighScores = new int[]
            //{
            //    highScores[0], highScores[1], highScores[2], 223, 143, 553
            //};

            //int[,] playerScores = new int[,]
            //{
            //    {30, 42, 50 },
            //    {42, 12, 60 }
            //};
            //Console.WriteLine(playerScores[1,2]);
            //var type = EngineType.hybrid;
            //type = EngineType.gasoline;

            //const EngineType anotherEngine = EngineType.hybrid;

            string[] nameArray = new string[3] { "Ejaz", "A", "Merchant" };
            //Console.WriteLine(nameArray[0]);
            //Console.WriteLine(nameArray[1]);
            //Console.WriteLine(nameArray[2]);
            Console.WriteLine($"Hello, {nameArray[0]} {nameArray[1]} {nameArray[2]}");


        }
    }
}
