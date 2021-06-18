using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First3
{
    public class GradeBook
    {


        public GradeBook()
        {
            grades= new List<float>();
        }

        public void AddGrade(float grade) {
            grades.Add(grade);        
        }

        List<float> grades;
        public string Name;



        public GradeStat ComputeStatistics() {
            GradeStat stats = new GradeStat();           

            float sum = 0;
            foreach (float grade in grades) {

                stats.High = Math.Max(grade, stats.High);
                stats.Low = Math.Min(grade, stats.Low);              
                sum += grade;
            }

            stats.Av = sum / grades.Count;
            return stats;
        }

    }
}
