using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace m_add
{
    internal class Coordinates : ICoord
    {
        public string AtomName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Coordinates(string atomName ,double x, double y, double z)
        {
            AtomName = atomName;
            X = x;
            Y = y;
            Z = z;
        }
    }
}
