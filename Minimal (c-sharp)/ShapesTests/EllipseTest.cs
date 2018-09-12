using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTests
{
    [TestClass]
    public class EllipseTest
    {
        [TestMethod]
        public void TestValidConstruction()
        {
            Rectangle myRectangle = new Rectangle(-2, -1, -2, 1, 2, 1, 2, -1);
            var Ellipse = new Ellipse(myRectangle);
            //var Ellipse = new Ellipse(-2, -1, -2, 1, 2, 1, 2, -1);

            Assert.AreEqual(0, Ellipse.Center.X);
            Assert.AreEqual(0, Ellipse.Center.Y);
            Assert.AreEqual(-1.73205080757, Ellipse.Foci1.X, 0.0001);
            Assert.AreEqual(0, Ellipse.Foci1.Y);
            Assert.AreEqual(1.73205080757, Ellipse.Foci2.X, 0.0001);
            Assert.AreEqual(0, Ellipse.Foci2.Y);

            Assert.AreEqual(-2, Ellipse.Vertex1.X);
            Assert.AreEqual(0, Ellipse.Vertex1.Y);
            Assert.AreEqual(0, Ellipse.Vertex2.X);
            Assert.AreEqual(1, Ellipse.Vertex2.Y);
            Assert.AreEqual(2, Ellipse.Vertex3.X);
            Assert.AreEqual(0, Ellipse.Vertex3.Y);
            Assert.AreEqual(0, Ellipse.Vertex4.X);
            Assert.AreEqual(-1, Ellipse.Vertex4.Y);

            Line _Axis1 = new Line(-2, 0, 2, 0);
            Line _Axis2 = new Line(0, 1, 0, -1);

            Assert.AreEqual(_Axis1.Point1.X, Ellipse.Axis1.Point1.X);
            Assert.AreEqual(_Axis1.Point1.Y, Ellipse.Axis1.Point1.Y);
            Assert.AreEqual(_Axis1.Point2.X, Ellipse.Axis1.Point2.X);
            Assert.AreEqual(_Axis1.Point2.Y, Ellipse.Axis1.Point2.Y);

            Assert.AreEqual(_Axis2.Point1.X, Ellipse.Axis2.Point1.X);
            Assert.AreEqual(_Axis2.Point1.Y, Ellipse.Axis2.Point1.Y);
            Assert.AreEqual(_Axis2.Point2.X, Ellipse.Axis2.Point2.X);
            Assert.AreEqual(_Axis2.Point2.Y, Ellipse.Axis2.Point2.Y);

            Rectangle _BindingRectangle = new Rectangle(-2, -1, -2, 1, 2, 1, 2, -1);
            Assert.AreEqual(_BindingRectangle.Vertex1.X, Ellipse.BindingRectangle.Vertex1.X);
            Assert.AreEqual(_BindingRectangle.Vertex1.Y, Ellipse.BindingRectangle.Vertex1.Y);
            Assert.AreEqual(_BindingRectangle.Vertex2.X, Ellipse.BindingRectangle.Vertex2.X);
            Assert.AreEqual(_BindingRectangle.Vertex2.Y, Ellipse.BindingRectangle.Vertex2.Y);
            Assert.AreEqual(_BindingRectangle.Vertex3.X, Ellipse.BindingRectangle.Vertex3.X);
            Assert.AreEqual(_BindingRectangle.Vertex3.Y, Ellipse.BindingRectangle.Vertex3.Y);
            Assert.AreEqual(_BindingRectangle.Vertex4.X, Ellipse.BindingRectangle.Vertex4.X);
            Assert.AreEqual(_BindingRectangle.Vertex4.Y, Ellipse.BindingRectangle.Vertex4.Y);
        }
    }
}
