using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double GetAverage(List<double> Grades)
        {
            return Grades.Sum() / Grades.Count;
        }
    }
}
