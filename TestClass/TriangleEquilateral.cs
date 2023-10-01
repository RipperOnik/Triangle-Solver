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

}
