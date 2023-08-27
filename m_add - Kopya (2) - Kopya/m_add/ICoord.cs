using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace m_add
{
    internal interface ICoord
    {
        string AtomName { get; set; }
        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }

    }
}
