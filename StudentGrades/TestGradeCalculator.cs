using System;
using NUnit.Framework;

namespace StudentGrades
{
    [TestFixture]
    public class TestGradeCalculator
    {
        private GradeCalculator _gradeCalculator;

        [SetUp]
        public void SetUp()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [Test]
        public void TestGetGradeByPercentage()
        {
            var percentage = 99;

            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            Assert.That("A", Is.EqualTo(grade));

        }
    }
}
