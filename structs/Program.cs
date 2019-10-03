using System;

namespace Structs
{
    class Program
    {

        static void Main(string[] args)
        {
            var student1 = new Student();
            student1.firstName = "Shamilah";
            student1.lastName = "Merchant";
            student1.GPA = 4.0;

            //Console.WriteLine($"The student {student1.firstName} {student1.lastName} GPA is {student1.GPA}");
            var grades = new double[] { 1.0, 2.0, 3.0 };

            student1.CalculateGPA(grades);

            Console.WriteLine(student1.GPA);
        }
    }
}
