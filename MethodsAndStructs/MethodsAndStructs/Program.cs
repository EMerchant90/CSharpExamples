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
            var service = new WebService();
            var data = service.GetStudentProfile(100);

            Console.WriteLine(data.student.firstName + " " + data.Item1.lastName);
            Console.WriteLine(data.grades[0]);
            //var UXforVR = new BookReview();

            //UXforVR.SetName("UXforVR");
            //UXforVR.SetScore(7);

            //Console.WriteLine(UXforVR.GetName());
            //Console.WriteLine(UXforVR.GetScore());
        }
    } 
}
