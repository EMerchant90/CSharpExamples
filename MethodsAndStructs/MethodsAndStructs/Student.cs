using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndStructs
{
    struct Student
    {
        public string firstName;
        public string lastName;
        public double GPA;

        public void CalculateGPA(double[] grades)
        {
            foreach (var grade in grades)
            {
                GPA += grade;
            }
            if (GPA > 0)
            {
                GPA /= grades.Length + 1;
            }
            else
            {
                GPA /= grades.Length;
            }
        }
    }

}
