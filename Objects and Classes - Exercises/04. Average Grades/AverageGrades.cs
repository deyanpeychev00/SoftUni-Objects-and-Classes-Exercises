using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    public class AverageGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var excellentStudents = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();

                var student = new Student
                {
                    Name = input[0],
                    Grades = new List<double>()
                };
                for (int j = 1; j < input.Count; j++)
                {
                    student.Grades.Add(double.Parse(input[j]));
                }
                var studentAverage = student.GetAverage(student.Grades);
                if (studentAverage >= 5)
                {
                    excellentStudents.Add(student);
                }
            }
            excellentStudents = excellentStudents.OrderBy(x => x.Name).ThenByDescending(x => x.Grades.Average()).ToList();
            
            for (int i = 0; i < excellentStudents.Count; i++)
            {
                var getAverage = excellentStudents[i].Grades.Sum() / excellentStudents[i].Grades.Count();
                Console.WriteLine($"{excellentStudents[i].Name} -> {getAverage:f2}");
            }
        }
    }
}

