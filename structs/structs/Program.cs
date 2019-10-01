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

            var tesla = new Car();
            tesla.Name = "Roadster";
            tesla.Engine = EngineType.electric;
            tesla.color = "red";

            Console.WriteLine($"{tesla.Name} - {tesla.color}");
        }
    }
}
