using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    //tuples
    struct WebService
    {
        public (Student student, int[] grades) GetStudentProfile(int id)
        {
            var student = new Student();
            student.firstName = "Joe";
            student.lastName = "Average";
            var grades = new int[] { 35, 60, 50 };
            return (student, grades);
        }
    }
}
