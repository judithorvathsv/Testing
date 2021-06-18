using System;

namespace First3
{
    class Program
    {
        static void Main(string[] args)
        {


       

            
            GradeBook b = new GradeBook();
            b.AddGrade(91);
            b.AddGrade(89.5f);
            b.AddGrade(75);
  


            GradeStat stats = b.ComputeStatistics();
            Console.WriteLine(stats.Av);
            Console.WriteLine(stats.Low);
            Console.WriteLine(stats.High);
          

            //Console.Read();

        }
    }


}
