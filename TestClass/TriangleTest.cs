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
    [TestFixture]
    public class TriangleScalene
    {
        [Test]
        public void AnalyzeTriangle_Input3and4and5_OutputSCALENE()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 5;

            string expected = "A triangle is formed and it is a SCALENE";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_Input5and7and10_OutputSCALENE()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 7;
            int thirdSide = 10;

            string expected = "A triangle is formed and it is a SCALENE";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_Input4and5and8_OutputSCALENE()
        {
            // Arrange
            int firstSide = 4;
            int secondSide = 5;
            int thirdSide = 8;

            string expected = "A triangle is formed and it is a SCALENE";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input6and7and9_OutputSCALENE()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 7;
            int thirdSide = 9;

            string expected = "A triangle is formed and it is a SCALENE";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void AnalyzeTriangle_Input13and12and14_OutputSCALENE()
        {
            // Arrange
            int firstSide = 13;
            int secondSide = 12;
            int thirdSide = 14;

            string expected = "A triangle is formed and it is a SCALENE";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

    }
    [TestFixture]
    public class TriangleZeroLength
    {

        [Test]
        public void AnalyzeTriangle_Input0and1and2_OutputSCALENE()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 1;
            int thirdSide = 2;

            string expected = "INVALID triangle - a zero was entered";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input0and0and2_OutputSCALENE()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 2;

            string expected = "INVALID triangle - a zero was entered";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input0and0and0_OutputSCALENE()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;

            string expected = "INVALID triangle - a zero was entered";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
    [TestFixture]
    public class TriangleInvalidResponse
    {
        [Test]
        public void AnalyzeTriangle_Input1and2and3_OutputSCALENE()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 3;

            string expected = "A triangle is not formed based on the input values";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input2and3and6_OutputSCALENE()
        {
            // Arrange
            int firstSide = 2;
            int secondSide = 3;
            int thirdSide = 6;

            string expected = "A triangle is not formed based on the input values";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_Input4and5and10_OutputSCALENE()
        {
            // Arrange
            int firstSide = 4;
            int secondSide = 5;
            int thirdSide = 10;

            string expected = "A triangle is not formed based on the input values";

            // Act 
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }

}
