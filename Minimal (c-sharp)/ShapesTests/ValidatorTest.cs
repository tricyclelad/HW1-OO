using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesTests
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void TestValidateDouble()
        {
            Validator.ValidateDouble(123, "Test message");
            Validator.ValidateDouble(0.00123, "Test message");
            Validator.ValidateDouble(-123, "Test message");
            Validator.ValidateDouble(-0.00123, "Test messagee");

            try
            {
                Validator.ValidateDouble(double.PositiveInfinity, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }

            try
            {
                Validator.ValidateDouble(double.NegativeInfinity, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }

            try
            {
                Validator.ValidateDouble(double.NaN, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }
        }

        [TestMethod]
        public void TestValidatePositiveDouble()
        {
            Validator.ValidatePositiveDouble(456, "Test message");
            Validator.ValidatePositiveDouble(0.34523, "Test message");

            try
            {
                Validator.ValidatePositiveDouble(-123, "Negative not allowed");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Negative not allowed", ex.Message);
            }

            try
            {
                Validator.ValidatePositiveDouble(-0.123, "Negative not allowed");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Negative not allowed", ex.Message);
            }

            try
            {
                Validator.ValidatePositiveDouble(double.PositiveInfinity, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }

            try
            {
                Validator.ValidatePositiveDouble(double.NegativeInfinity, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }

            try
            {
                Validator.ValidatePositiveDouble(double.NaN, "Invalid");
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException ex)
            {
                Assert.AreEqual("Invalid", ex.Message);
            }
        }
        [TestMethod]
        public void TestArePointsEqual()
        {
            Point Point1 = new Point(0,0);
            Point Point2 = new Point(0,0);
            Point Point3 = new Point(1,2);
            Point Point4 = new Point(4,3);
            Point Point5 = new Point(-1,0);

            Assert.IsTrue(Validator.ArePointsEqual(Point1,Point2));
            Assert.IsTrue(Validator.ArePointsEqual(Point1,Point1));
            Assert.IsFalse(Validator.ArePointsEqual(Point1,Point3));
            Assert.IsFalse(Validator.ArePointsEqual(Point4,Point5));

        }
        [TestMethod]
        public void TestAreLinesEqual()
        {
            Line Line1 = new Line(0,0,10,10);
            Line Line2 = new Line(0,0,10,10);
            Line Line3 = new Line(0,0,12,12);
            Line Line4 = new Line(12,12,10,10);
            Line Line5 = new Line(1,1,5,5);

            Assert.IsTrue(Validator.AreLinesEqual(Line1,Line2)); 
            Assert.IsTrue(Validator.AreLinesEqual(Line1,Line1)); 
            Assert.IsFalse(Validator.AreLinesEqual(Line1,Line3)); 
            Assert.IsFalse(Validator.AreLinesEqual(Line1,Line4)); 
            Assert.IsFalse(Validator.AreLinesEqual(Line1,Line5)); 
            Assert.IsFalse(Validator.AreLinesEqual(Line4,Line3)); 
            Assert.IsTrue(Validator.AreLinesEqual(Line5,Line5)); 


        }
    }
}
