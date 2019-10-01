using System;
namespace structs
{
    public struct StudentStruct
    {
        public string firstName;
        public string lastName;
        public double GPA;

        private static void Main()
        {
            var student1 = new StudentStruct();
            student1.firstName = "Shamilah";
            student1.lastName = "Merchant";
            student1.GPA = 4.0;

            Console.WriteLine($"The student {student1.firstName} {student1.lastName} GPA is {student1.GPA}");
        }
    }
}

            