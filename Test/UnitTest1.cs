using NUnit.Framework;
using First3;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public void ComputeHighestGrade() {
            GradeBook b = new GradeBook();
            b.AddGrade(10);
            b.AddGrade(90);

            GradeStat result = b.ComputeStatistics();
            Assert.AreEqual(90, result.High);
        }


        public void ComputeLowestGrade()
        {
            GradeBook b = new GradeBook();
            b.AddGrade(10);
            b.AddGrade(90);

            GradeStat result = b.ComputeStatistics();
            Assert.AreEqual(90, result.Low);
        }

        public void ComputeAverageGrade()
        {
            GradeBook b = new GradeBook();
            b.AddGrade(91);
            b.AddGrade(89.5f);
            b.AddGrade(75);

            GradeStat result = b.ComputeStatistics();
            Assert.AreEqual(85.16f, result.Av, 0.1);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}