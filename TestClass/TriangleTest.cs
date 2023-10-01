using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleEquilateral
    {
        [Test]
        public void AnalyzeTriangle_Input10and10and10_OutputEQUILATERAL()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 10;

            string expected = "A triangle is formed and it is an EQUILATERAL";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
    [TestFixture]
    public class TriangleIsosceles
    {
        [Test]
        public void AnalyzeTriangle_Input10and10and15_OutputISOSCELES()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 15;

            string expected = "A triangle is formed and it is an ISOSCELES";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_Input7and7and14_OutputISOSCELES()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 7;
            int thirdSide = 12;

            string expected = "A triangle is formed and it is an ISOSCELES";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_Input2and2and3_OutputISOSCELES()
        {
            // Arrange
            int firstSide = 2;
            int secondSide = 2;
            int thirdSide = 3;

            string expected = "A triangle is formed and it is an ISOSCELES";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

    }
}
