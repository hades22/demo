using demo.Dmain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Service
{
    public class ShapeService: IShapeService
    {
        public List<string> GetAll()
        {
            var shapes = new List<string>();
            var l = new List<IShape>();
            l.Add(new Square());
            l.Add(new Circle());
            foreach(var s in l)
            {
                shapes.Add(s.Draw());
            }
            return shapes;
        }

        public double SquareArea(double length)
        {
            return length * length;
        }
    }
}
