using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gradeCalculator = new GradeCalculator();

            Console.WriteLine("Enter the percentage: ");
            var percentage = Convert.ToInt32(Console.ReadLine());

            var grade = gradeCalculator.GetGradeByPercentage(percentage);

            Console.WriteLine("Student Grade: {0}", grade);
        }
    }
}
