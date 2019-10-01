using System;

namespace PracticeBasics
{
    class Program
    {

        enum RingType
        {
            Pear, Marquise, Round, Pop
        };

        static void Main(string[] args)
        {
            RingType forHer = RingType.Pear;
            var ring = RingType.Round;
            var message = String.Empty;

            if (forHer == RingType.Pear)
            {
                Console.WriteLine("Um no");
            }
            else
            {
                Console.WriteLine("Trueee");
            }


            switch(forHer)
            {
                case RingType.Marquise:
                    message = "You are going to be a star";
                    break;
                case RingType.Pear:
                    message = "You are un-pear-able";
                    break;
                case RingType.Round:
                    message = "You are well-rounded";
                    break;
                default:
                    message = "You is broke";
                    break;
            }

            Console.WriteLine(message);

            string[] traitsOfShamilah = new string[5]{ "Happy", "Hungry", "Angry", "Sexy", "Smarty" };

            foreach (var traits in traitsOfShamilah)
            {
                Console.WriteLine(traits);
            }
        }
    }
}
