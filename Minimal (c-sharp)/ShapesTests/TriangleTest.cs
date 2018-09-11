using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTests
{
    [TestClass]
    public class TriangleTest
    {

        [TestMethod]
        public void TestValidConstruction()
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(1, 1);
            var p3 = new Point(2, 0);
            var p4 = new Point(3,3);
            var myTriangle = new Triangle(0, 0, 1, 1, 2, 0);

            Assert.AreEqual(0, myTriangle.Vertex1.X, 0);
            Assert.AreEqual(0, myTriangle.Vertex1.Y, 0);
            Assert.AreEqual(1, myTriangle.Vertex2.X, 0);
            Assert.AreEqual(1, myTriangle.Vertex2.Y, 0);
            Assert.AreEqual(2, myTriangle.Vertex3.X, 0);
            Assert.AreEqual(0, myTriangle.Vertex3.Y, 0);

            try
            {
                myTriangle = new Triangle(0, 0, 1, 1, 0, 0);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {

                Assert.AreEqual("Two or more Triangle Vertices are equal", e.Message);
            }

            try
            {
                myTriangle = new Triangle(0, 0, 1, 1, 3, 3);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid triangle edges: 1 or more lines are in same location", e.Message);
            }

            try
            {
                myTriangle = new Triangle(0, 0, 1,-1, 3, -3);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid triangle edges: 1 or more lines are in same location", e.Message);
            }

            try
            {
                myTriangle = new Triangle(p1, p2, p1);
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Triangle Vertices are equal", e.Message);
            }

            try
            {
                myTriangle = new Triangle(p1, p1, p1);
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Triangle Vertices are equal", e.Message);
            }

            try
            {
                myTriangle = new Triangle(p2, p1, p1);
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Two or more Triangle Vertices are equal", e.Message);
            }


            try
            {
                myTriangle = new Triangle(p1,p2,p4);
                Assert.Fail("Expected exception not thrown");
            }
            catch (ShapeException e)
            {
                Assert.AreEqual("Invalid triangle edges: 1 or more lines are in same location", e.Message);
            }
            p1 = new Point(1.4, 2.5);
            p2 = new Point(4.6, 10.7);
            p3 = new Point(5.6, 13.7);
            myTriangle = new Triangle(p1, p2, p3);
            Assert.AreSame(p1, myTriangle.Vertex1);
            Assert.AreSame(p2, myTriangle.Vertex2);
            Assert.AreSame(p3, myTriangle.Vertex3);

            myTriangle = new Triangle(0.1, 0.1, 1.1, 1.1, 2.1, 0.1);

            Assert.AreEqual(0.1, myTriangle.Vertex1.X, 0);
            Assert.AreEqual(0.1, myTriangle.Vertex1.Y, 0);
            Assert.AreEqual(1.1, myTriangle.Vertex2.X, 0);
            Assert.AreEqual(1.1, myTriangle.Vertex2.Y, 0);
            Assert.AreEqual(2.1, myTriangle.Vertex3.X, 0);
            Assert.AreEqual(0.1, myTriangle.Vertex3.Y, 0);
        }
    }
}
