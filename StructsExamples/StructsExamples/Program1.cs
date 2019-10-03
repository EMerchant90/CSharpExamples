using System;

namespace structs
{
    class Program
    {

        //struct City
        //{
        //    public string Name;
        //    public int Size;
        //    public string Location;
        //}

        static void Main(string[] args)
        {
			//var myCity = new City();
			//myCity.Name = "Atlanta";

			//var tesla = new Car();
			//tesla.Name = "Roadster";
			//tesla.Engine = EngineType.electric;
			//tesla.color = "red";

			//Console.WriteLine($"{tesla.Name} - {tesla.color}");

			var student1 = new StudentStruct();
			student1.firstName = "Shamilah";
			student1.lastName = "Merchant";
			student1.GPA = 4.0;
          

			//Console.WriteLine($"The student {student1.firstName} {student1.lastName} GPA is {student1.GPA}");
			var grades = new double[] { 1.0, 2.0, 3.0 };

		}
    }
}