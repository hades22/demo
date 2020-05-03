using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Service
{
    public interface IShapeService
    {
        List<string> GetAll();
        double SquareArea(double length);
    }
}
