using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle
    {
        public Point Vertex1 { get; private set; }
        public Point Vertex2 { get; private set; }
        public Point Vertex3 { get; private set; }
        public Line Edge1 { get; private set; }
        public Line Edge2 { get; private set; }
        public Line Edge3 { get; private set; }


        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Vertex1 = new Point(x1, y1);
            Vertex2 = new Point(x2, y2);
            Vertex3 = new Point(x3, y3);
            Edge1 = new Line(Vertex1, Vertex2); 
            Edge2 = new Line(Vertex2, Vertex3); 
            Edge3 = new Line(Vertex3, Vertex1); 

        }
        public Triangle(Point _Vertex1, Point _Vertex2, Point _Vertex3)
        {
            Vertex1 = _Vertex1;
            Vertex2 = _Vertex2;
            Vertex3 = _Vertex3;
            Edge1 = new Line(Vertex1, Vertex2); 
            Edge2 = new Line(Vertex2, Vertex3); 
            Edge3 = new Line(Vertex3, Vertex1); 


        }
    }
}
