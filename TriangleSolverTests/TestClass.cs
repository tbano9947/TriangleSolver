using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using TriangleSolver;

namespace TriangleSolverTests
{
    [TestFixture]
    public class TestClass
    {
        // 1 Test for a valid Equilateral triangle
        [Test]
        public void AnalyzeTriangle_Equilateral_ReturnsEquilateral()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 5;
            string expected = "Equilateral triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }
        // 3 Tests for a valid Isosceles triangle
        [Test]
        public void AnalyzeTriangle_Isosceles_TwoEqualSides1_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 3;
            string expected = "Isosceles triangle";
            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Isosceles_TwoEqualSides2_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 6, side2 = 4, side3 = 6;
            string expected = "Isosceles triangle";
            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Isosceles_TwoEqualSides3_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 7, side2 = 9, side3 = 9;
            string expected = "Isosceles triangle";
            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
         
            ClassicAssert.AreEqual(expected, actual);
        }
        // 5 Tests for a valid Scalene triangle
        [Test]
        public void AnalyzeTriangle_Scalene_UniqueSides1_ReturnsScalene()
        {
            // Arrange
            int side1 = 4, side2 = 5, side3 = 6;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Scalene_UniqueSides2_ReturnsScalene()
        {
            // Arrange
            int side1 = 7, side2 = 8, side3 = 9;
            string expected = "Scalene triangle";
            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Scalene_UniqueSides3_ReturnsScalene()
        {
            // Arrange
            int side1 = 10, side2 = 12, side3 = 15;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Scalene_UniqueSides4_ReturnsScalene()
        {
            // Arrange
            int side1 = 13, side2 = 17, side3 = 19;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Scalene_UniqueSides5_ReturnsScalene()
        {
            // Arrange
            int side1 = 9, side2 = 12, side3 = 14;
            string expected = "Scalene triangle";

            // Act
            string actual = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }


    }
}
