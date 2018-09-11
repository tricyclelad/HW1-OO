using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle
    {
        public Point Vertex1 { get; private set; }
        public Point Vertex2 { get; private set; }
        public Point Vertex3 { get; private set; }
        public Point Vertex4 { get; private set; }
        public Line Width { get; private set; }
        public Line Height { get; private set; }

        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            Vertex1 = new Point(x1,y1);
            Vertex2 = new Point(x2,y2);
            Vertex3 = new Point(x3,y3);
            Vertex4 = new Point(x4,y4);
            if(AreVerticesEqual(Vertex1, Vertex2, Vertex3, Vertex4))
            {
                throw new ShapeException("Two or more Square Vertices are equal");
            }
            Width = new Line(Vertex1, Vertex2);
            Height = new Line(Vertex1, Vertex4);
            if(!AreSidesSameLength())
            {
                throw new ShapeException("Two or more corresponding sides are not equal lengths");
            }
            if(!AreVerticesSquared())
            {
                throw new ShapeException("Atleast one vertex is not squared with the other vertices");
            }
        }
        public bool AreVerticesEqual(Point _Vertex1, Point _Vertex2, Point _Vertex3, Point _Vertex4)
        {
            if (Validator.ArePointsEqual(_Vertex1, _Vertex2))
            {
                return true;
            }

            if (Validator.ArePointsEqual(_Vertex1, _Vertex3))
            {
                return true;
            }

            if (Validator.ArePointsEqual(_Vertex1, _Vertex4))
            {
                return true;
            }

            if (Validator.ArePointsEqual(_Vertex2, _Vertex3))
            {
                return true;
            }
            
            if (Validator.ArePointsEqual(_Vertex2, _Vertex4))
            {
                return true;
            }

            if (Validator.ArePointsEqual(_Vertex3, _Vertex4))
            {
                return true;
            }
            return false;

        }
        public bool AreSidesSameLength()
        {
            Line Width1 = new Line(Vertex1, Vertex2);
            Line Width2 = new Line(Vertex3, Vertex4);
            Line Height1 = new Line(Vertex1, Vertex4);
            Line Height2 = new Line(Vertex2, Vertex3);
            if (Validator.AreLineLengthsEqual(Width1, Width2) && Validator.AreLineLengthsEqual(Height1, Height2))
                return true;
            return false;
        }
        public bool AreVerticesSquared()
        {

            return false;
        }

    }
}
