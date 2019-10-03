using System;
namespace StructChallengeBookReview
{
    class Program
    {
        static void Main()
        {
            var UXforVR = new BookReview();

            UXforVR.SetName("UXforVR");
            UXforVR.SetScore(7);

            Console.WriteLine(UXforVR.GetName());
            Console.WriteLine(UXforVR.GetScore());
        }
    }
}
